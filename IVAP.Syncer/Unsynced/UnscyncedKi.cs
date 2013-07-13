using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvHelper.Configuration;

namespace IVAP.Syncer
{
    public class UnscyncedKI
    {
        [CsvField(Name = "start")]
        public string start { get; set; }
        [CsvField(Name = "end")]
        public string end { get; set; }
        [CsvField(Name = "today")]
        public string today { get; set; }
        [CsvField(Name = "District")]
        public string District { get; set; }
        [CsvField(Name = "Tehsil")]
        public string Tehsil { get; set; }
        [CsvField(Name = "UC")]
        public string UC { get; set; }
        [CsvField(Name = "village")]
        public string village { get; set; }
        [CsvField(Name = "interviewer_name")]
        public string interviewer_name { get; set; }
        public string respondent_name { get; set; }
        public string gender { get; set; }
        public string occupation { get; set; }
        public string occupation_other { get; set; }
        public string contact { get; set; }
        public string displaced_family { get; set; }
        public string old_family { get; set; }
        public string no_family_reason { get; set; }
        public string origin_area { get; set; }
        public string register { get; set; }
        public string BHU { get; set; }
        public string BHU_sufficient { get; set; }
        public string no_BHU { get; set; }
        public string no_BHU_other { get; set; }
        public string health_problem { get; set; }
        public string health_problem_other { get; set; }
        public string medical_staff { get; set; }
        public string child_disease { get; set; }
        //public string village_BHU { get; set; }
        public string distance { get; set; }
        public string boys_school { get; set; }
        public string b_grade { get; set; }
        public string girls_school { get; set; }
        public string g_grade { get; set; }
        public string govt_school { get; set; }
        public string mistreat_idp { get; set; }
        public string school_setup { get; set; }
        public string school_setup_other { get; set; }
        public string water_source { get; set; }
        public string clean_water { get; set; }
        public string latrine { get; set; }
        public string danger_zone { get; set; }
        public string violence { get; set; }
        public string violence_other { get; set; }
        public string overall_security { get; set; }
        public string overall_security_name { get; set; }
        public string community { get; set; }
        public string rent { get; set; }
        public string separated_child { get; set; }
        public string num_separate { get; set; }
        public string contact_idp { get; set; }
        [CsvField(Name = "meta:instanceID")]
        public string MetaInstanceID { get; set; }
    }
}
