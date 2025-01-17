﻿using CSETWebCore.DataLayer.Manual;
using CSETWebCore.DataLayer.Model;
using CSETWebCore.Interfaces.Analytics;
using CSETWebCore.Model.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSETWebCore.Business.Analytics
{
    public class AnalyticsBusiness: IAnalyticsBusiness
    {
        private CSETContext _context;

        public AnalyticsBusiness(CSETContext context)
        {
            _context = context;

        }
        
        
        public List<DataRowsAnalytics> getMaturityDashboardData(int maturity_model_id)
        {
           var minMax = _context.analytics_Compute_MaturityAll(maturity_model_id).ToList();
            var median = _context.analytics_Compute_MaturityAll_Median(maturity_model_id).ToList();
            var rvalue =  from a in minMax join b in median on a.Title equals b.Title
                        select new DataRowsAnalytics() { title=a.Title, avg=(int)a.avg,max=(int)a.max,min=(int)a.min,median=b.median};
            return rvalue.ToList();
        }

        public List<AnalyticsgetMedianOverall> GetMaturityGroupsForAssessment(int assessmentId, int maturity_model_id)
        {
            return _context.analytics_compute_single_averages_maturity(assessmentId,maturity_model_id).ToList();
        }
    }
}
