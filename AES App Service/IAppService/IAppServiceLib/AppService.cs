using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IAppServiceLib
{
    public class AppService : IAppService
    {
        public List<Job> getJobs(int storeId)
        {
            List<Job> jobs = new List<Job>();

            using (ApplicantEntities context = new ApplicantEntities())
            {
                var city = (from c in context.AvailablePositions where storeId == c.storeId select c);

                foreach (var p in city)
                {
                    var temp = new Job();
                    temp.jTitle = p.Position.title;
                    temp.jDescription = p.Position.description;
                    temp.jPay = p.Position.pay;
                    temp.jDays = p.workingDays;
                    temp.jAvailPosId = p.availablePosId;
                    jobs.Add(temp);
                }
                return jobs;
            }
        }

        public Store getStoreInfo(int storeId)
        {
            Store aStore = new Store();
            using (ApplicantEntities context = new ApplicantEntities())
            {
                var store = (from p in context.Stores where storeId == p.storeId select p);

                foreach (var x in store)
                {
                    aStore.name = x.name;
                    aStore.address = x.address;
                    aStore.city = x.city;
                    aStore.stateAbbreviation = x.stateAbbreviation;
                }
                return aStore;
            }
        }
    }
}
