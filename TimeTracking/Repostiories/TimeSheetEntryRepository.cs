using System;
using System.Collections.Generic;
using LiteDB;
using TimeTracking.Models;

namespace TimeTracking.Repostiories
{
    public interface ITimeSheetEntryRepository
    {
        TimeSheetEntry Add(TimeSheetEntry entry);

        IEnumerable<TimeSheetEntry> GetAll();

        TimeSheetEntry GetById(int id);

        bool RemoveAll();

        bool Remove(int id);

    }

    public class TimeSheetEntryRepository : ITimeSheetEntryRepository, IDisposable
    {
        private readonly string _connectionString = "";
        private readonly string _schemaName = "TimeSheetDetail";
        private readonly LiteDatabase _db;
        private readonly LiteCollection<TimeSheetEntry> _collection;

        public TimeSheetEntryRepository()
        {
            _db = new LiteDatabase(_connectionString);
            _collection = _db.GetCollection<TimeSheetEntry>(_schemaName);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public TimeSheetEntry Add(TimeSheetEntry entry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TimeSheetEntry> GetAll()
        {
            return _collection.FindAll();
        }

        public TimeSheetEntry GetById(int id)
        {
            return _collection.FindById(id);
        }

        public bool RemoveAll()
        {
            return _collection.Delete(x => true) != 0;
        }

        public bool Remove(int id)
        {
            return _collection.Delete(x => x.Id == id) != 0;
        }
    }
}
