using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeCounter
{
    public class Record
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private DateTime _lastUpdate;
        public DateTime LastUpdate
        {
            get { return _lastUpdate; }
            set { _lastUpdate = value; }
        }

        private Dictionary<DateTime, double> _timers;
        [XmlIgnore]
        public Dictionary<DateTime, double> Timers
        {
            get { return _timers; }
            set { _timers = value; }
        }

        private List<TimeCounter> _timeCounters;
        public List<TimeCounter> TimeCounters
        {
            get { return _timeCounters; }
            set { _timeCounters = value; }
        }

        private double _undatedTimer;
        public double UndatedTimer
        {
            get { return _undatedTimer; }
            set { _undatedTimer = value; }
        }

        public string UndatedTimerString
        {
            get
            {
                TimeSpan timespan = TimeSpan.FromSeconds(UndatedTimer);
                return GetStringFotTimeSpan(timespan);
            }
        }

        public double TotalTimer
        {
            get
            {
                double result = UndatedTimer;
                foreach (DateTime key in Timers.Keys)
                    result += Timers[key];
                return result;
            }
        }

        public string TotalTimerString
        {
            get
            {
                TimeSpan timespan = TimeSpan.FromSeconds(TotalTimer);
                return GetStringFotTimeSpan(timespan);
            }
        }

        public static string GetStringForTimers(Dictionary<string, double> data)
        {
            double sum = 0;
            data.Values.ToList().ForEach(v => sum += v);
            if (sum > 0)
                return Record.GetStringFotTimeSpan(TimeSpan.FromSeconds(sum));
            else
                return "";
        }

        public static string GetStringFotTimeSpan(TimeSpan timespan)
        {
            return string.Format("{0}:{1:00}:{2:00}", Math.Floor(timespan.TotalHours), timespan.Minutes, timespan.Seconds);
        }

        public Record()
        {
            Name = "";
            LastUpdate = DateTime.Now;
            Timers = new Dictionary<DateTime, double>();
            UndatedTimer = 0;
        }

        public override string ToString()
        {
            return Name;
        }

        public static int CompareByDate(Record a, Record b)
        {
            if (a.LastUpdate == b.LastUpdate)
                return string.Compare(a.Name, b.Name);
            return DateTime.Compare(b.LastUpdate, a.LastUpdate);
        }

        public class TimeCounter
        {
            public DateTime Date { get; set; }
            public double Counter { get; set; }

            public TimeCounter() { }
            public TimeCounter(DateTime date, double counter)
            {
                Date = date;
                Counter = counter;
            }

            public static int CompareByDate(TimeCounter a, TimeCounter b)
            {
                return DateTime.Compare(b.Date, a.Date);
            }
        }
    }

    public class RecordsCollection
    {
        private static string fileName = "Timers.xml";
        private static RecordsCollection _recordsCollection;

        private List<Record> _records;
        public List<Record> Records
        {
            get { return _records; }
            set { _records = value; }
        }

        private RecordsCollection()
        {
            Records = new List<Record>();
        }

        public static RecordsCollection GetInstance()
        {
            if (_recordsCollection == null)
                _recordsCollection = Load();
            return _recordsCollection;
        }

        public static bool Save()
        {
            foreach (Record record in GetInstance().Records)
            {
                List<Record.TimeCounter> result = new List<Record.TimeCounter>();
                foreach (DateTime key in record.Timers.Keys)
                    result.Add(new Record.TimeCounter(key, record.Timers[key]));
                record.TimeCounters = result;
            }
            try
            {
                XmlHelper.SerializeAndSave(fileName, GetInstance());
                return Check();
            }
            catch
            {
                return false;
            }
        }

        private static bool Check()
        {
            try
            {
                RecordsCollection toCheck = fileName.LoadAndDeserialize<RecordsCollection>();
                if (toCheck.Records.Count != GetInstance().Records.Count)
                    return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

        private static RecordsCollection Load()
        {
            RecordsCollection result;
            try
            {
                result = fileName.LoadAndDeserialize<RecordsCollection>();
            }
            catch
            {
                return new RecordsCollection();
            }

            foreach (Record record in result.Records)
            {
                record.Timers.Clear();
                foreach (Record.TimeCounter timeCounter in record.TimeCounters)
                {
                    if (!record.Timers.ContainsKey(timeCounter.Date))
                        record.Timers.Add(timeCounter.Date, 0);
                    record.Timers[timeCounter.Date] += timeCounter.Counter;
                }
            }
            result.Records.Sort(Record.CompareByDate);

            return result;
        }

        public static void Add(Record record)
        {
            GetInstance().Records.Add(record);
            GetInstance().Records.Sort(Record.CompareByDate);
        }

        public static void UpdateRecord(Record record)
        {
            record.LastUpdate = DateTime.Now;
            GetInstance().Records.Sort(Record.CompareByDate);
        }

        public static Dictionary<string, double> GetTimersByDate(DateTime date)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();
            foreach (Record record in GetInstance().Records)
                if (record.Timers.ContainsKey(date.Date))
                    result[record.Name] = record.Timers[date.Date];
            return result;
        }

        public static Dictionary<string, double> GetTimersByPeriod(DateTime dateStart, DateTime dateEnd)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();
            foreach (Record record in GetInstance().Records)
                foreach (DateTime key in record.Timers.Keys)
                    if (key >= dateStart.Date && key <= dateEnd.Date)
                    {
                        if (!result.ContainsKey(record.Name))
                            result.Add(record.Name, 0);
                        result[record.Name] += record.Timers[key];
                    }
            return result;
        }

        public static Record GetRecordByName(string name)
        {
            return GetInstance().Records.Find(r => r.Name == name);
        }
    }
}
