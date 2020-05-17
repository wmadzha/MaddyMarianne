using MaddyMarianne.Business.Model.DomainA;
using System.Collections.Generic;

namespace MaddyMarianne.DataAccess.DomainA
{
    public class DomainAEngine
    {
        //IDatabaseContext _ctx;
        public DomainAEngine()
        {

        }
        /// <summary>
        /// Use DI for Our Dependencies Data Store
        /// </summary>
        /// <returns></returns>
        //public DomainAEngine(IDatabaseContext ctx)
        //{

        //}

        public bool AddDomainAObject(string jsonObjectString)
        {
            // Boundaries Call To Add
            return true;
        }

        public bool DeleteDomainAObject(string objectId)
        {
            return true;
        }
        public bool UpdateDomainObject(string obj)
        {
            return true;
        }
        public List<DomainAExampleObject> GetAll()
        {
            return new List<DomainAExampleObject>();
        }
    }
}
