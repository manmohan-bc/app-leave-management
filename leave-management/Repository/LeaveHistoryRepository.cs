using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveHistoryRepository : Contracts.ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        #region Contructor
        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        #endregion

        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            return true;
        }

        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            var LeaveHistorys = _db.LeaveHistories.ToList();
            return LeaveHistorys;
        }

        public LeaveHistory FindById(int id)
        {
            var LeaveHistory = _db.LeaveHistories.Find(id);
            return LeaveHistory;
        }

        public bool IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);
            return Save();
        }
    }
}
