using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvHelper.Configuration;

namespace IVAP.Syncer
{
    public class SyncedKI
    {
        public string start { get; set; }
        public string end { get; set; }
        public string today { get; set; }
        public string District { get; set; }
        public string Tehsil { get; set; }
        public string UC { get; set; }
        public string village { get; set; }
        public string interviewer_name { get; set; }
        public string respondent_name { get; set; }
        public string gender { get; set; }
        public string occupation { get; set; }

        public string occupation_a { get; set; }
        public string occupation_b { get; set; }
        public string occupation_c { get; set; }
        public string occupation_d { get; set; }
        public string occupation_e { get; set; }
        public string occupation_f { get; set; }



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

        public string no_BHU_a { get; set; }
        public string no_BHU_b { get; set; }
        public string no_BHU_c { get; set; }
        public string no_BHU_d { get; set; }
        public string no_BHU_e { get; set; }
        public string no_BHU_f { get; set; }



        public string no_BHU_other { get; set; }
        public string health_problem { get; set; }

        public string health_problem_a { get; set; }
        public string health_problem_b { get; set; }
        public string health_problem_c { get; set; }
        public string health_problem_d { get; set; }
        public string health_problem_e { get; set; }
        public string health_problem_f { get; set; }
        public string health_problem_g { get; set; }
        public string health_problem_h { get; set; }
        public string health_problem_i { get; set; }



        public string health_problem_other { get; set; }
        public string medical_staff { get; set; }
        public string child_disease { get; set; }
        //public string village_BHU { get; set; }
        [CsvField(Name = "distance")]
        public string distance { get; set; }
        public string boys_school { get; set; }
        public string b_grade { get; set; }
        public string girls_school { get; set; }
        public string g_grade { get; set; }
        public string govt_school { get; set; }
        public string mistreat_idp { get; set; }
        public string school_setup { get; set; }

        public string school_setup_a { get; set; }
        public string school_setup_b { get; set; }
        public string school_setup_c { get; set; }
        public string school_setup_d { get; set; }
        public string school_setup_e { get; set; }

        public string school_setup_other { get; set; }
        public string water_source { get; set; }
        public string clean_water { get; set; }
        public string latrine { get; set; }
        public string danger_zone { get; set; }

        public string danger_zone_a { get; set; }
        public string danger_zone_b { get; set; }
        public string danger_zone_c { get; set; }
        public string danger_zone_d { get; set; }
        public string danger_zone_e { get; set; }
        public string danger_zone_f { get; set; }
        public string danger_zone_g { get; set; }
        public string danger_zone_h { get; set; }
        public string danger_zone_i { get; set; }
        public string danger_zone_j { get; set; }
        public string danger_zone_k { get; set; }

        public string violence { get; set; }

        public string violence_a { get; set; }
        public string violence_b { get; set; }
        public string violence_c { get; set; }
        public string violence_d { get; set; }
        public string violence_e { get; set; }
        public string violence_f { get; set; }
        public string violence_g { get; set; }
        public string violence_h { get; set; }
        public string violence_i { get; set; }


        public string violence_other { get; set; }
        public string overall_security { get; set; }
        public string overall_security_name { get; set; }
        public string community { get; set; }

        public string community_a { get; set; }
        public string community_b { get; set; }
        public string community_c { get; set; }
        public string community_d { get; set; }
        public string community_e { get; set; }
        public string community_f { get; set; }


        public string rent { get; set; }
        public string separated_child { get; set; }
        public string num_separate { get; set; }
        public string contact_idp { get; set; }
        [CsvField(Name = "meta:instanceID")]
        public string MetaInstanceID { get; set; }

    }
}
