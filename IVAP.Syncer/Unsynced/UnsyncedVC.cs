using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvHelper.Configuration;

namespace IVAP.Syncer
{
    public class UnsyncedVC
    {
        [CsvField(Name = "name")]
        public string name { get; set; }
        [CsvField(Name = "nic")]
        public string nic { get; set; }
        [CsvField(Name = "family_num")]
        public string family_num { get; set; }
        [CsvField(Name = "origin")]
        public string origin { get; set; }
        [CsvField(Name = "today")]
        public string today { get; set; }
        [CsvField(Name = "nic_type")]
        public string nic_type { get; set; }
        [CsvField(Name = "NIC_Type_1:h_location")]
        public string h_name { get; set; }
        [CsvField(Name = "NIC_Type_1:o_location")]
        public string o_name { get; set; }
        [CsvField(Name = "host_add")]
        public string host_add { get; set; }
        [CsvField(Name = "origin_add")]
        public string origin_add { get; set; }
        [CsvField(Name = "origin_notify")]
        public string origin_notify { get; set; }
        [CsvField(Name = "possess_cnic")]
        public string possess_nic { get; set; }
        [CsvField(Name = "family_members")]
        public string family_members { get; set; }

        [CsvField(Name = "family:Family_member_1:name_1")]
        public string name_1 { get; set; }
        [CsvField(Name = "family:Family_member_1:relationship")]
        public string relationship_1 { get; set; }
        [CsvField(Name = "family:Family_member_1:nic_1")]
        public string nic_1 { get; set; }

        [CsvField(Name = "family:Family_member_2:name_2")]
        public string name_2 { get; set; }
        [CsvField(Name = "family:Family_member_2:relationship")]
        public string relationship_2 { get; set; }
        [CsvField(Name = "family:Family_member_2:nic_2")]
        public string nic_2 { get; set; }

        [CsvField(Name = "family:Family_member_3:name_3")]
        public string name_3 { get; set; }
        [CsvField(Name = "family:Family_member_3:relationship")]
        public string relationship_3 { get; set; }
        [CsvField(Name = "family:Family_member_3:nic_3")]
        public string nic_3 { get; set; }

        [CsvField(Name = "family:Family_member_4:name_4")]
        public string name_4 { get; set; }
        [CsvField(Name = "family:Family_member_4:relationship")]
        public string relationship_4 { get; set; }
        [CsvField(Name = "family:Family_member_4:nic_4")]
        public string nic_4 { get; set; }

        [CsvField(Name = "family:Family_member_5:name_5")]
        public string name_5 { get; set; }
        [CsvField(Name = "family:Family_member_5:relationship")]
        public string relationship_5 { get; set; }
        [CsvField(Name = "family:Family_member_5:nic_5")]
        public string nic_5 { get; set; }

        [CsvField(Name = "family:Family_member_6:name_6")]
        public string name_6 { get; set; }
        [CsvField(Name = "family:Family_member_6:relationship")]
        public string relationship_6 { get; set; }
        [CsvField(Name = "family:Family_member_6:nic_6")]
        public string nic_6 { get; set; }


        [CsvField(Name = "family:Family_member_7:name_7")]
        public string name_7 { get; set; }
        [CsvField(Name = "family:Family_member_7:relationship")]
        public string relationship_7 { get; set; }
        [CsvField(Name = "family:Family_member_7:nic_7")]
        public string nic_7 { get; set; }


        [CsvField(Name = "family:Family_member_8:name_8")]
        public string name_8 { get; set; }
        [CsvField(Name = "family:Family_member_8:relationship")]
        public string relationship_8 { get; set; }
        [CsvField(Name = "family:Family_member_8:nic_8")]
        public string nic_8 { get; set; }

        [CsvField(Name = "family:Family_member_9:name_9")]
        public string name_9 { get; set; }
        [CsvField(Name = "family:Family_member_9:relationship")]
        public string relationship_9 { get; set; }
        [CsvField(Name = "family:Family_member_9:nic_9")]
        public string nic_9 { get; set; }

        [CsvField(Name = "family:Family_member_10:name_10")]
        public string name_10 { get; set; }
        [CsvField(Name = "family:Family_member_10:relationship")]
        public string relationship_10 { get; set; }
        [CsvField(Name = "family:Family_member_10:nic_10")]
        public string nic_10 { get; set; }


        [CsvField(Name = "verified_by")]
        public string verified_by { get; set; }

        [CsvField(Name = "dept_name")]
        public string dept_name { get; set; }

        [CsvField(Name = "dept_name_other")]
        public string dept_name_other { get; set; }

        [CsvField(Name = "contact")]
        public string address { get; set; }

        [CsvField(Name = "displacement_doc")]
        public string displacement_doc { get; set; }

        [CsvField(Name = "doc_type")]
        public string doc_type { get; set; }

        [CsvField(Name = "respondent_accent")]
        public string respondent_accent { get; set; }

        










    }
}
