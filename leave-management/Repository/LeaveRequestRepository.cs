using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveRequestRepository : Contracts.ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _db;

        #region Contructor
        public LeaveRequestRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        #endregion

        public bool Create(LeaveRequest entity)
        {
            _db.LeaveRequests.Add(entity);
            return Save();
        }

        public bool Delete(LeaveRequest entity)
        {
            _db.LeaveRequests.Remove(entity);
            return Save();
        }

        public ICollection<LeaveRequest> FindAll()
        {
            var LeaveHistorys = _db.LeaveRequests
                .Include(o => o.RequestingEmployee)
                .Include(o => o.ApprovedBy)
                .Include(o => o.LeaveType)
                .ToList();
            return LeaveHistorys;
        }

        public LeaveRequest FindById(int id)
        {
            var LeaveRequests = _db.LeaveRequests
                .Include(o => o.RequestingEmployee)
                .Include(o => o.ApprovedBy)
                .Include(o => o.LeaveType)
                .FirstOrDefault(o => o.Id == id);
                
            return LeaveRequests;
        }

        public ICollection<LeaveRequest> GetLeaveRequestsByEmployee(string employeeId)
        {
            var leaveRequest = FindAll().Where(o => o.RequestingEmployeeId == employeeId).ToList();
            return leaveRequest;
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

        public bool Update(LeaveRequest entity)
        {
            _db.LeaveRequests.Update(entity);
            return Save();
        }
    }
}
