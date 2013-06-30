using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvHelper.Configuration;

namespace IVAP.Syncer
{
    public class UnsyncedIV
    {
        [CsvField(Name = "today")]
        public string today { get; set; }

        [CsvField(Name = "GI4")]
        public string GI4 { get; set; }
        [CsvField(Name = "District")]
        public string District { get; set; }
        [CsvField(Name = "Tehsil")]
        public string Tehsil { get; set; }
        [CsvField(Name = "UC")]
        public string UC { get; set; }
        [CsvField(Name = "GI8")]
        public string GI8 { get; set; }
        [CsvField(Name = "GI9")]
        public string GI9 { get; set; }

        [CsvField(Name = "IO1")]
        public string IO1 { get; set; }

        [CsvField(Name = "IDP:IO2")]
        public string IO2 { get; set; }

        [CsvField(Name = "IDP:IO2_other")]
        public string IO2_other { get; set; }

        [CsvField(Name = "IDP:IO2a_other")]
        public string IO2a_other { get; set; }

        [CsvField(Name = "IDP:IO2a")]
        public string IO2a { get; set; }

        [CsvField(Name = "IDP:SI2c")]
        public string SI2c { get; set; }

        [CsvField(Name = "IDP:tir")]
        public string tir { get; set; }

        [CsvField(Name = "IDP:IO3")]
        public string IO3 { get; set; }

        [CsvField(Name = "IDP:IO5")]
        public string IO5 { get; set; }

        [CsvField(Name = "IDP:GI:GI5")]
        public string GI5 { get; set; }

        [CsvField(Name = "IDP:GI:GI5a")]
        public string GI5a { get; set; }

        [CsvField(Name = "IDP:GI:relationhip")]
        public string relationship { get; set; }

        [CsvField(Name = "IDP:GI1:HL11a")]
        public string HL11a { get; set; }

        [CsvField(Name = "IDP:HL12a")]
        public string HL12a { get; set; }

        [CsvField(Name = "IDP:HL14")]
        public string HL14 { get; set; }

        [CsvField(Name = "IDP:HL9")]
        public string HL9 { get; set; }

        [CsvField(Name = "IDP:token")]
        public string token { get; set; }

        [CsvField(Name = "IDP:token_date")]
        public string token_date { get; set; }

        [CsvField(Name = "IDP:HLF")]
        public string HLF { get; set; }

        [CsvField(Name = "IDP:GIPA_1")]
        public string GIPA_1 { get; set; }

        [CsvField(Name = "IDP:GI2:FH")]
        public string FH { get; set; }

        [CsvField(Name = "IDP:GI2:GI13")]
        public string GI13 { get; set; }

        [CsvField(Name = "IDP:GI2:GI14")]
        public string GI14 { get; set; }


        [CsvField(Name = "IDP:GI2:GI15")]
        public string GI15 { get; set; }

        [CsvField(Name = "IDP:GI2:GI16")]
        public string GI16 { get; set; }

        [CsvField(Name = "IDP:HH_1:HL2_1")]
        public string HL2_1 { get; set; }

        [CsvField(Name = "IDP:HH_1:HL8_1")]
        public string HL8_1 { get; set; }

        [CsvField(Name = "IDP:HH_1:HL3_1")]
        public string HL3_1 { get; set; }

        [CsvField(Name = "IDP:HH_1:HL4_1")]
        public string HL4_1 { get; set; }

        [CsvField(Name = "IDP:HH_1:HL5_1")]
        public string HL5_1 { get; set; }

        [CsvField(Name = "IDP:HH_1:HL6_1")]
        public string HL6_1 { get; set; }

        [CsvField(Name = "IDP:HH_1:HL7_1")]
        public string HL7_1 { get; set; }

        [CsvField(Name = "IDP:HH_1:phy_disable_1")]
        public string phy_disable_1 { get; set; }

        [CsvField(Name = "IDP:HH_1:p_1_other")]
        public string p_1_other { get; set; }

        [CsvField(Name = "IDP:HH_1:chr_ill_1")]
        public string chr_ill_1 { get; set; }

        [CsvField(Name = "IDP:HH_1:chr_ill_1_Other")]
        public string chr_ill_1_Other { get; set; }

        [CsvField(Name = "IDP:HH_2:HL2_2")]
        public string HL2_2 { get; set; }

        [CsvField(Name = "IDP:HH_2:HL3_2")]
        public string HL3_2 { get; set; }

        [CsvField(Name = "IDP:HH_2:HL4_2")]
        public string HL4_2 { get; set; }

        [CsvField(Name = "IDP:HH_2:HL5_2")]
        public string HL5_2 { get; set; }

        [CsvField(Name = "IDP:HH_2:HL6_2")]
        public string HL6_2 { get; set; }

        [CsvField(Name = "IDP:HH_2:HL6a_2")]
        public string HL6a_2 { get; set; }

        [CsvField(Name = "IDP:HH_2:HL7_2")]
        public string HL7_2 { get; set; }

        [CsvField(Name = "IDP:HH_2:phy_disable_2")]
        public string phy_disable_2 { get; set; }

        [CsvField(Name = "IDP:HH_2:p_2_other")]
        public string p_2_other { get; set; }

        [CsvField(Name = "IDP:HH_2:chr_ill_2")]
        public string chr_ill_2 { get; set; }

        [CsvField(Name = "IDP:HH_2:chr_ill_2_Other")]
        public string chr_ill_2_Other { get; set; }

        [CsvField(Name = "IDP:HH_2:MUAC_2")]
        public string MUAC_2 { get; set; }

        [CsvField(Name = "IDP:HH_3:HL2_3")]
        public string HL2_3 { get; set; }

        [CsvField(Name = "IDP:HH_3:HL3_3")]
        public string HL3_3 { get; set; }

        [CsvField(Name = "IDP:HH_3:HL4_3")]
        public string HL4_3 { get; set; }

        [CsvField(Name = "IDP:HH_3:HL5_3")]
        public string HL5_3 { get; set; }

        [CsvField(Name = "IDP:HH_3:HL6_3")]
        public string HL6_3 { get; set; }

        [CsvField(Name = "IDP:HH_3:HL6a_3")]
        public string HL6a_3 { get; set; }

        [CsvField(Name = "IDP:HH_3:HL7_3")]
        public string HL7_3 { get; set; }

        [CsvField(Name = "IDP:HH_3:phy_disable_3")]
        public string phy_disable_3 { get; set; }

        [CsvField(Name = "IDP:HH_3:p_3_other")]
        public string p_3_other { get; set; }

        [CsvField(Name = "IDP:HH_3:chr_ill_3")]
        public string chr_ill_3 { get; set; }

        [CsvField(Name = "IDP:HH_3:chr_ill_3_Other")]
        public string chr_ill_3_Other { get; set; }

        [CsvField(Name = "IDP:HH_3:MUAC_3")]
        public string MUAC_3 { get; set; }


        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_4:HL2_4")]
        public string HL2_4 { get; set; }

        [CsvField(Name = "IDP:HH_4:HL3_4")]
        public string HL3_4 { get; set; }

        [CsvField(Name = "IDP:HH_4:HL4_4")]
        public string HL4_4 { get; set; }

        [CsvField(Name = "IDP:HH_4:HL5_4")]
        public string HL5_4 { get; set; }

        [CsvField(Name = "IDP:HH_4:HL6_4")]
        public string HL6_4 { get; set; }

        [CsvField(Name = "IDP:HH_4:HL6a_4")]
        public string HL6a_4 { get; set; }

        [CsvField(Name = "IDP:HH_4:HL7_4")]
        public string HL7_4 { get; set; }

        [CsvField(Name = "IDP:HH_4:phy_disable_4")]
        public string phy_disable_4 { get; set; }

        [CsvField(Name = "IDP:HH_4:p_4_other")]
        public string p_4_other { get; set; }

        [CsvField(Name = "IDP:HH_4:chr_ill_4")]
        public string chr_ill_4 { get; set; }

        [CsvField(Name = "IDP:HH_4:chr_ill_4_Other")]
        public string chr_ill_4_Other { get; set; }

        [CsvField(Name = "IDP:HH_4:MUAC_4")]
        public string MUAC_4 { get; set; }


        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_5:HL2_5")]
        public string HL2_5 { get; set; }

        [CsvField(Name = "IDP:HH_5:HL3_5")]
        public string HL3_5 { get; set; }

        [CsvField(Name = "IDP:HH_5:HL4_5")]
        public string HL4_5 { get; set; }

        [CsvField(Name = "IDP:HH_5:HL5_5")]
        public string HL5_5 { get; set; }

        [CsvField(Name = "IDP:HH_5:HL6_5")]
        public string HL6_5 { get; set; }

        [CsvField(Name = "IDP:HH_5:HL6a_5")]
        public string HL6a_5 { get; set; }

        [CsvField(Name = "IDP:HH_5:HL7_5")]
        public string HL7_5 { get; set; }

        [CsvField(Name = "IDP:HH_5:phy_disable_5")]
        public string phy_disable_5 { get; set; }

        [CsvField(Name = "IDP:HH_5:p_5_other")]
        public string p_5_other { get; set; }

        [CsvField(Name = "IDP:HH_5:chr_ill_5")]
        public string chr_ill_5 { get; set; }

        [CsvField(Name = "IDP:HH_5:chr_ill_5_Other")]
        public string chr_ill_5_Other { get; set; }

        [CsvField(Name = "IDP:HH_5:MUAC_5")]
        public string MUAC_5 { get; set; }

        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_6:HL2_6")]
        public string HL2_6 { get; set; }

        [CsvField(Name = "IDP:HH_6:HL3_6")]
        public string HL3_6 { get; set; }

        [CsvField(Name = "IDP:HH_6:HL4_6")]
        public string HL4_6 { get; set; }

        [CsvField(Name = "IDP:HH_6:HL5_6")]
        public string HL5_6 { get; set; }

        [CsvField(Name = "IDP:HH_6:HL6_6")]
        public string HL6_6 { get; set; }

        [CsvField(Name = "IDP:HH_6:HL6a_6")]
        public string HL6a_6 { get; set; }

        [CsvField(Name = "IDP:HH_6:HL7_6")]
        public string HL7_6 { get; set; }

        [CsvField(Name = "IDP:HH_6:phy_disable_6")]
        public string phy_disable_6 { get; set; }

        [CsvField(Name = "IDP:HH_6:p_6_other")]
        public string p_6_other { get; set; }

        [CsvField(Name = "IDP:HH_6:chr_ill_6")]
        public string chr_ill_6 { get; set; }

        [CsvField(Name = "IDP:HH_6:chr_ill_6_Other")]
        public string chr_ill_6_Other { get; set; }

        [CsvField(Name = "IDP:HH_6:MUAC_6")]
        public string MUAC_6 { get; set; }


        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_7:HL2_7")]
        public string HL2_7 { get; set; }

        [CsvField(Name = "IDP:HH_7:HL3_7")]
        public string HL3_7 { get; set; }

        [CsvField(Name = "IDP:HH_7:HL4_7")]
        public string HL4_7 { get; set; }

        [CsvField(Name = "IDP:HH_7:HL5_7")]
        public string HL5_7 { get; set; }

        [CsvField(Name = "IDP:HH_7:HL6_7")]
        public string HL6_7 { get; set; }

        [CsvField(Name = "IDP:HH_7:HL6a_7")]
        public string HL6a_7 { get; set; }

        [CsvField(Name = "IDP:HH_7:HL7_7")]
        public string HL7_7 { get; set; }

        [CsvField(Name = "IDP:HH_7:phy_disable_7")]
        public string phy_disable_7 { get; set; }

        [CsvField(Name = "IDP:HH_7:p_7_other")]
        public string p_7_other { get; set; }

        [CsvField(Name = "IDP:HH_7:chr_ill_7")]
        public string chr_ill_7 { get; set; }

        [CsvField(Name = "IDP:HH_7:chr_ill_7_Other")]
        public string chr_ill_7_Other { get; set; }

        [CsvField(Name = "IDP:HH_7:MUAC_7")]
        public string MUAC_7 { get; set; }

        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_8:HL2_8")]
        public string HL2_8 { get; set; }

        [CsvField(Name = "IDP:HH_8:HL3_8")]
        public string HL3_8 { get; set; }

        [CsvField(Name = "IDP:HH_8:HL4_8")]
        public string HL4_8 { get; set; }

        [CsvField(Name = "IDP:HH_8:HL5_8")]
        public string HL5_8 { get; set; }

        [CsvField(Name = "IDP:HH_8:HL6_8")]
        public string HL6_8 { get; set; }

        [CsvField(Name = "IDP:HH_8:HL6a_8")]
        public string HL6a_8 { get; set; }

        [CsvField(Name = "IDP:HH_8:HL7_8")]
        public string HL7_8 { get; set; }

        [CsvField(Name = "IDP:HH_8:phy_disable_8")]
        public string phy_disable_8 { get; set; }

        [CsvField(Name = "IDP:HH_8:p_8_other")]
        public string p_8_other { get; set; }

        [CsvField(Name = "IDP:HH_8:chr_ill_8")]
        public string chr_ill_8 { get; set; }

        [CsvField(Name = "IDP:HH_8:chr_ill_8_Other")]
        public string chr_ill_8_Other { get; set; }

        [CsvField(Name = "IDP:HH_8:MUAC_8")]
        public string MUAC_8 { get; set; }

        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_9:HL2_9")]
        public string HL2_9 { get; set; }

        [CsvField(Name = "IDP:HH_9:HL3_9")]
        public string HL3_9 { get; set; }

        [CsvField(Name = "IDP:HH_9:HL4_9")]
        public string HL4_9 { get; set; }

        [CsvField(Name = "IDP:HH_9:HL5_9")]
        public string HL5_9 { get; set; }

        [CsvField(Name = "IDP:HH_9:HL6_9")]
        public string HL6_9 { get; set; }

        [CsvField(Name = "IDP:HH_9:HL6a_9")]
        public string HL6a_9 { get; set; }

        [CsvField(Name = "IDP:HH_9:HL7_9")]
        public string HL7_9 { get; set; }

        [CsvField(Name = "IDP:HH_9:phy_disable_9")]
        public string phy_disable_9 { get; set; }

        [CsvField(Name = "IDP:HH_9:p_9_other")]
        public string p_9_other { get; set; }

        [CsvField(Name = "IDP:HH_9:chr_ill_9")]
        public string chr_ill_9 { get; set; }

        [CsvField(Name = "IDP:HH_9:chr_ill_9_Other")]
        public string chr_ill_9_Other { get; set; }

        [CsvField(Name = "IDP:HH_9:MUAC_9")]
        public string MUAC_9 { get; set; }


        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_10:HL2_10")]
        public string HL2_10 { get; set; }

        [CsvField(Name = "IDP:HH_10:HL3_10")]
        public string HL3_10 { get; set; }

        [CsvField(Name = "IDP:HH_10:HL4_10")]
        public string HL4_10 { get; set; }

        [CsvField(Name = "IDP:HH_10:HL5_10")]
        public string HL5_10 { get; set; }

        [CsvField(Name = "IDP:HH_10:HL6_10")]
        public string HL6_10 { get; set; }

        [CsvField(Name = "IDP:HH_10:HL6a_10")]
        public string HL6a_10 { get; set; }

        [CsvField(Name = "IDP:HH_10:HL7_10")]
        public string HL7_10 { get; set; }

        [CsvField(Name = "IDP:HH_10:phy_disable_10")]
        public string phy_disable_10 { get; set; }

        [CsvField(Name = "IDP:HH_10:p_10_other")]
        public string p_10_other { get; set; }

        [CsvField(Name = "IDP:HH_10:chr_ill_10")]
        public string chr_ill_10 { get; set; }

        [CsvField(Name = "IDP:HH_10:chr_ill_10_Other")]
        public string chr_ill_10_Other { get; set; }

        [CsvField(Name = "IDP:HH_10:MUAC_10")]
        public string MUAC_10 { get; set; }

        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_11:HL2_11")]
        public string HL2_11 { get; set; }

        [CsvField(Name = "IDP:HH_11:HL3_11")]
        public string HL3_11 { get; set; }

        [CsvField(Name = "IDP:HH_11:HL4_11")]
        public string HL4_11 { get; set; }

        [CsvField(Name = "IDP:HH_11:HL5_11")]
        public string HL5_11 { get; set; }

        [CsvField(Name = "IDP:HH_11:HL6_11")]
        public string HL6_11 { get; set; }

        [CsvField(Name = "IDP:HH_11:HL6a_11")]
        public string HL6a_11 { get; set; }

        [CsvField(Name = "IDP:HH_11:HL7_11")]
        public string HL7_11 { get; set; }

        [CsvField(Name = "IDP:HH_11:phy_disable_11")]
        public string phy_disable_11 { get; set; }

        [CsvField(Name = "IDP:HH_11:p_11_other")]
        public string p_11_other { get; set; }

        [CsvField(Name = "IDP:HH_11:chr_ill_11")]
        public string chr_ill_11 { get; set; }

        [CsvField(Name = "IDP:HH_11:chr_ill_11_Other")]
        public string chr_ill_11_Other { get; set; }

        [CsvField(Name = "IDP:HH_11:MUAC_11")]
        public string MUAC_11 { get; set; }

        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_12:HL2_12")]
        public string HL2_12 { get; set; }

        [CsvField(Name = "IDP:HH_12:HL3_12")]
        public string HL3_12 { get; set; }

        [CsvField(Name = "IDP:HH_12:HL4_12")]
        public string HL4_12 { get; set; }

        [CsvField(Name = "IDP:HH_12:HL5_12")]
        public string HL5_12 { get; set; }

        [CsvField(Name = "IDP:HH_12:HL6_12")]
        public string HL6_12 { get; set; }

        [CsvField(Name = "IDP:HH_12:HL6a_12")]
        public string HL6a_12 { get; set; }

        [CsvField(Name = "IDP:HH_12:HL7_12")]
        public string HL7_12 { get; set; }

        [CsvField(Name = "IDP:HH_12:phy_disable_12")]
        public string phy_disable_12 { get; set; }

        [CsvField(Name = "IDP:HH_12:p_12_other")]
        public string p_12_other { get; set; }

        [CsvField(Name = "IDP:HH_12:chr_ill_12")]
        public string chr_ill_12 { get; set; }

        [CsvField(Name = "IDP:HH_12:chr_ill_12_Other")]
        public string chr_ill_12_Other { get; set; }

        [CsvField(Name = "IDP:HH_12:MUAC_12")]
        public string MUAC_12 { get; set; }

        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_13:HL2_13")]
        public string HL2_13 { get; set; }

        [CsvField(Name = "IDP:HH_13:HL3_13")]
        public string HL3_13 { get; set; }

        [CsvField(Name = "IDP:HH_13:HL4_13")]
        public string HL4_13 { get; set; }

        [CsvField(Name = "IDP:HH_13:HL5_13")]
        public string HL5_13 { get; set; }

        [CsvField(Name = "IDP:HH_13:HL6_13")]
        public string HL6_13 { get; set; }

        [CsvField(Name = "IDP:HH_13:HL6a_13")]
        public string HL6a_13 { get; set; }

        [CsvField(Name = "IDP:HH_13:HL7_13")]
        public string HL7_13 { get; set; }

        [CsvField(Name = "IDP:HH_13:phy_disable_13")]
        public string phy_disable_13 { get; set; }

        [CsvField(Name = "IDP:HH_13:p_13_other")]
        public string p_13_other { get; set; }

        [CsvField(Name = "IDP:HH_13:chr_ill_13")]
        public string chr_ill_13 { get; set; }

        [CsvField(Name = "IDP:HH_13:chr_ill_13_Other")]
        public string chr_ill_13_Other { get; set; }

        [CsvField(Name = "IDP:HH_13:MUAC_13")]
        public string MUAC_13 { get; set; }

        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_14:HL2_14")]
        public string HL2_14 { get; set; }

        [CsvField(Name = "IDP:HH_14:HL3_14")]
        public string HL3_14 { get; set; }

        [CsvField(Name = "IDP:HH_14:HL4_14")]
        public string HL4_14 { get; set; }

        [CsvField(Name = "IDP:HH_14:HL5_14")]
        public string HL5_14 { get; set; }

        [CsvField(Name = "IDP:HH_14:HL6_14")]
        public string HL6_14 { get; set; }

        [CsvField(Name = "IDP:HH_14:HL6a_14")]
        public string HL6a_14 { get; set; }

        [CsvField(Name = "IDP:HH_14:HL7_14")]
        public string HL7_14 { get; set; }

        [CsvField(Name = "IDP:HH_14:phy_disable_14")]
        public string phy_disable_14 { get; set; }

        [CsvField(Name = "IDP:HH_14:p_14_other")]
        public string p_14_other { get; set; }

        [CsvField(Name = "IDP:HH_14:chr_ill_14")]
        public string chr_ill_14 { get; set; }

        [CsvField(Name = "IDP:HH_14:chr_ill_14_Other")]
        public string chr_ill_14_Other { get; set; }

        [CsvField(Name = "IDP:HH_14:MUAC_14")]
        public string MUAC_14 { get; set; }


        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_15:HL2_15")]
        public string HL2_15 { get; set; }

        [CsvField(Name = "IDP:HH_15:HL3_15")]
        public string HL3_15 { get; set; }

        [CsvField(Name = "IDP:HH_15:HL4_15")]
        public string HL4_15 { get; set; }

        [CsvField(Name = "IDP:HH_15:HL5_15")]
        public string HL5_15 { get; set; }

        [CsvField(Name = "IDP:HH_15:HL6_15")]
        public string HL6_15 { get; set; }

        [CsvField(Name = "IDP:HH_15:HL6a_15")]
        public string HL6a_15 { get; set; }

        [CsvField(Name = "IDP:HH_15:HL7_15")]
        public string HL7_15 { get; set; }

        [CsvField(Name = "IDP:HH_15:phy_disable_15")]
        public string phy_disable_15 { get; set; }

        [CsvField(Name = "IDP:HH_15:p_15_other")]
        public string p_15_other { get; set; }

        [CsvField(Name = "IDP:HH_15:chr_ill_15")]
        public string chr_ill_15 { get; set; }

        [CsvField(Name = "IDP:HH_15:chr_ill_15_Other")]
        public string chr_ill_15_Other { get; set; }

        [CsvField(Name = "IDP:HH_15:MUAC_15")]
        public string MUAC_15 { get; set; }


        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_16:HL2_16")]
        public string HL2_16 { get; set; }

        [CsvField(Name = "IDP:HH_16:HL3_16")]
        public string HL3_16 { get; set; }

        [CsvField(Name = "IDP:HH_16:HL4_16")]
        public string HL4_16 { get; set; }

        [CsvField(Name = "IDP:HH_16:HL5_16")]
        public string HL5_16 { get; set; }

        [CsvField(Name = "IDP:HH_16:HL6_16")]
        public string HL6_16 { get; set; }

        [CsvField(Name = "IDP:HH_16:HL6a_16")]
        public string HL6a_16 { get; set; }

        [CsvField(Name = "IDP:HH_16:HL7_16")]
        public string HL7_16 { get; set; }

        [CsvField(Name = "IDP:HH_16:phy_disable_16")]
        public string phy_disable_16 { get; set; }

        [CsvField(Name = "IDP:HH_16:p_16_other")]
        public string p_16_other { get; set; }

        [CsvField(Name = "IDP:HH_16:chr_ill_16")]
        public string chr_ill_16 { get; set; }

        [CsvField(Name = "IDP:HH_16:chr_ill_16_Other")]
        public string chr_ill_16_Other { get; set; }

        [CsvField(Name = "IDP:HH_16:MUAC_16")]
        public string MUAC_16 { get; set; }


        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_17:HL2_17")]
        public string HL2_17 { get; set; }

        [CsvField(Name = "IDP:HH_17:HL3_17")]
        public string HL3_17 { get; set; }

        [CsvField(Name = "IDP:HH_17:HL4_17")]
        public string HL4_17 { get; set; }

        [CsvField(Name = "IDP:HH_17:HL5_17")]
        public string HL5_17 { get; set; }

        [CsvField(Name = "IDP:HH_17:HL6_17")]
        public string HL6_17 { get; set; }

        [CsvField(Name = "IDP:HH_17:HL6a_17")]
        public string HL6a_17 { get; set; }

        [CsvField(Name = "IDP:HH_17:HL7_17")]
        public string HL7_17 { get; set; }

        [CsvField(Name = "IDP:HH_17:phy_disable_17")]
        public string phy_disable_17 { get; set; }

        [CsvField(Name = "IDP:HH_17:p_17_other")]
        public string p_17_other { get; set; }

        [CsvField(Name = "IDP:HH_17:chr_ill_17")]
        public string chr_ill_17 { get; set; }

        [CsvField(Name = "IDP:HH_17:chr_ill_17_Other")]
        public string chr_ill_17_Other { get; set; }

        [CsvField(Name = "IDP:HH_17:MUAC_17")]
        public string MUAC_17 { get; set; }

        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_18:HL2_18")]
        public string HL2_18 { get; set; }

        [CsvField(Name = "IDP:HH_18:HL3_18")]
        public string HL3_18 { get; set; }

        [CsvField(Name = "IDP:HH_18:HL4_18")]
        public string HL4_18 { get; set; }

        [CsvField(Name = "IDP:HH_18:HL5_18")]
        public string HL5_18 { get; set; }

        [CsvField(Name = "IDP:HH_18:HL6_18")]
        public string HL6_18 { get; set; }

        [CsvField(Name = "IDP:HH_18:HL6a_18")]
        public string HL6a_18 { get; set; }

        [CsvField(Name = "IDP:HH_18:HL7_18")]
        public string HL7_18 { get; set; }

        [CsvField(Name = "IDP:HH_18:phy_disable_18")]
        public string phy_disable_18 { get; set; }

        [CsvField(Name = "IDP:HH_18:p_18_other")]
        public string p_18_other { get; set; }

        [CsvField(Name = "IDP:HH_18:chr_ill_18")]
        public string chr_ill_18 { get; set; }

        [CsvField(Name = "IDP:HH_18:chr_ill_18_Other")]
        public string chr_ill_18_Other { get; set; }

        [CsvField(Name = "IDP:HH_18:MUAC_18")]
        public string MUAC_18 { get; set; }


        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_19:HL2_19")]
        public string HL2_19 { get; set; }

        [CsvField(Name = "IDP:HH_19:HL3_19")]
        public string HL3_19 { get; set; }

        [CsvField(Name = "IDP:HH_19:HL4_19")]
        public string HL4_19 { get; set; }

        [CsvField(Name = "IDP:HH_19:HL5_19")]
        public string HL5_19 { get; set; }

        [CsvField(Name = "IDP:HH_19:HL6_19")]
        public string HL6_19 { get; set; }

        [CsvField(Name = "IDP:HH_19:HL6a_19")]
        public string HL6a_19 { get; set; }

        [CsvField(Name = "IDP:HH_19:HL7_19")]
        public string HL7_19 { get; set; }

        [CsvField(Name = "IDP:HH_19:phy_disable_19")]
        public string phy_disable_19 { get; set; }

        [CsvField(Name = "IDP:HH_19:p_19_other")]
        public string p_19_other { get; set; }

        [CsvField(Name = "IDP:HH_19:chr_ill_19")]
        public string chr_ill_19 { get; set; }

        [CsvField(Name = "IDP:HH_19:chr_ill_19_Other")]
        public string chr_ill_19_Other { get; set; }

        [CsvField(Name = "IDP:HH_19:MUAC_19")]
        public string MUAC_19 { get; set; }


        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_20:HL2_20")]
        public string HL2_20 { get; set; }

        [CsvField(Name = "IDP:HH_20:HL3_20")]
        public string HL3_20 { get; set; }

        [CsvField(Name = "IDP:HH_20:HL4_20")]
        public string HL4_20 { get; set; }

        [CsvField(Name = "IDP:HH_20:HL5_20")]
        public string HL5_20 { get; set; }

        [CsvField(Name = "IDP:HH_20:HL6_20")]
        public string HL6_20 { get; set; }

        [CsvField(Name = "IDP:HH_20:HL6a_20")]
        public string HL6a_20 { get; set; }

        [CsvField(Name = "IDP:HH_20:HL7_20")]
        public string HL7_20 { get; set; }

        [CsvField(Name = "IDP:HH_20:phy_disable_20")]
        public string phy_disable_20 { get; set; }

        [CsvField(Name = "IDP:HH_20:p_20_other")]
        public string p_20_other { get; set; }

        [CsvField(Name = "IDP:HH_20:chr_ill_20")]
        public string chr_ill_20 { get; set; }

        [CsvField(Name = "IDP:HH_20:chr_ill_20_Other")]
        public string chr_ill_20_Other { get; set; }

        [CsvField(Name = "IDP:HH_20:MUAC_20")]
        public string MUAC_20 { get; set; }


        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_21:HL2_21")]
        public string HL2_21 { get; set; }

        [CsvField(Name = "IDP:HH_21:HL3_21")]
        public string HL3_21 { get; set; }

        [CsvField(Name = "IDP:HH_21:HL4_21")]
        public string HL4_21 { get; set; }

        [CsvField(Name = "IDP:HH_21:HL5_21")]
        public string HL5_21 { get; set; }

        [CsvField(Name = "IDP:HH_21:HL6_21")]
        public string HL6_21 { get; set; }

        [CsvField(Name = "IDP:HH_21:HL6a_21")]
        public string HL6a_21 { get; set; }

        [CsvField(Name = "IDP:HH_21:HL7_21")]
        public string HL7_21 { get; set; }

        [CsvField(Name = "IDP:HH_21:phy_disable_21")]
        public string phy_disable_21 { get; set; }

        [CsvField(Name = "IDP:HH_21:p_21_other")]
        public string p_21_other { get; set; }

        [CsvField(Name = "IDP:HH_21:chr_ill_21")]
        public string chr_ill_21 { get; set; }

        [CsvField(Name = "IDP:HH_21:chr_ill_21_Other")]
        public string chr_ill_21_Other { get; set; }

        [CsvField(Name = "IDP:HH_21:MUAC_21")]
        public string MUAC_21 { get; set; }


        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_22:HL2_22")]
        public string HL2_22 { get; set; }

        [CsvField(Name = "IDP:HH_22:HL3_22")]
        public string HL3_22 { get; set; }

        [CsvField(Name = "IDP:HH_22:HL4_22")]
        public string HL4_22 { get; set; }

        [CsvField(Name = "IDP:HH_22:HL5_22")]
        public string HL5_22 { get; set; }

        [CsvField(Name = "IDP:HH_22:HL6_22")]
        public string HL6_22 { get; set; }

        [CsvField(Name = "IDP:HH_22:HL6a_22")]
        public string HL6a_22 { get; set; }

        [CsvField(Name = "IDP:HH_22:HL7_22")]
        public string HL7_22 { get; set; }

        [CsvField(Name = "IDP:HH_22:phy_disable_22")]
        public string phy_disable_22 { get; set; }

        [CsvField(Name = "IDP:HH_22:p_22_other")]
        public string p_22_other { get; set; }

        [CsvField(Name = "IDP:HH_22:chr_ill_22")]
        public string chr_ill_22 { get; set; }

        [CsvField(Name = "IDP:HH_22:chr_ill_22_Other")]
        public string chr_ill_22_Other { get; set; }

        [CsvField(Name = "IDP:HH_22:MUAC_22")]
        public string MUAC_22 { get; set; }

        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_23:HL2_23")]
        public string HL2_23 { get; set; }

        [CsvField(Name = "IDP:HH_23:HL3_23")]
        public string HL3_23 { get; set; }

        [CsvField(Name = "IDP:HH_23:HL4_23")]
        public string HL4_23 { get; set; }

        [CsvField(Name = "IDP:HH_23:HL5_23")]
        public string HL5_23 { get; set; }

        [CsvField(Name = "IDP:HH_23:HL6_23")]
        public string HL6_23 { get; set; }

        [CsvField(Name = "IDP:HH_23:HL6a_23")]
        public string HL6a_23 { get; set; }

        [CsvField(Name = "IDP:HH_23:HL7_23")]
        public string HL7_23 { get; set; }

        [CsvField(Name = "IDP:HH_23:phy_disable_23")]
        public string phy_disable_23 { get; set; }

        [CsvField(Name = "IDP:HH_23:p_23_other")]
        public string p_23_other { get; set; }

        [CsvField(Name = "IDP:HH_23:chr_ill_23")]
        public string chr_ill_23 { get; set; }

        [CsvField(Name = "IDP:HH_23:chr_ill_23_Other")]
        public string chr_ill_23_Other { get; set; }

        [CsvField(Name = "IDP:HH_23:MUAC_23")]
        public string MUAC_23 { get; set; }

        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_24:HL2_24")]
        public string HL2_24 { get; set; }

        [CsvField(Name = "IDP:HH_24:HL3_24")]
        public string HL3_24 { get; set; }

        [CsvField(Name = "IDP:HH_24:HL4_24")]
        public string HL4_24 { get; set; }

        [CsvField(Name = "IDP:HH_24:HL5_24")]
        public string HL5_24 { get; set; }

        [CsvField(Name = "IDP:HH_24:HL6_24")]
        public string HL6_24 { get; set; }

        [CsvField(Name = "IDP:HH_24:HL6a_24")]
        public string HL6a_24 { get; set; }

        [CsvField(Name = "IDP:HH_24:HL7_24")]
        public string HL7_24 { get; set; }

        [CsvField(Name = "IDP:HH_24:phy_disable_24")]
        public string phy_disable_24 { get; set; }

        [CsvField(Name = "IDP:HH_24:p_24_other")]
        public string p_24_other { get; set; }

        [CsvField(Name = "IDP:HH_24:chr_ill_24")]
        public string chr_ill_24 { get; set; }

        [CsvField(Name = "IDP:HH_24:chr_ill_24_Other")]
        public string chr_ill_24_Other { get; set; }

        [CsvField(Name = "IDP:HH_24:MUAC_24")]
        public string MUAC_24 { get; set; }

        /// <summary>
        /// A new Household Member
        /// </summary>
        [CsvField(Name = "IDP:HH_25:HL2_25")]
        public string HL2_25 { get; set; }

        [CsvField(Name = "IDP:HH_25:HL3_25")]
        public string HL3_25 { get; set; }

        [CsvField(Name = "IDP:HH_25:HL4_25")]
        public string HL4_25 { get; set; }

        [CsvField(Name = "IDP:HH_25:HL5_25")]
        public string HL5_25 { get; set; }

        [CsvField(Name = "IDP:HH_25:HL6_25")]
        public string HL6_25 { get; set; }

        [CsvField(Name = "IDP:HH_25:HL6a_25")]
        public string HL6a_25 { get; set; }

        [CsvField(Name = "IDP:HH_25:HL7_25")]
        public string HL7_25 { get; set; }

        [CsvField(Name = "IDP:HH_25:phy_disable_25")]
        public string phy_disable_25 { get; set; }

        [CsvField(Name = "IDP:HH_25:p_25_other")]
        public string p_25_other { get; set; }

        [CsvField(Name = "IDP:HH_25:chr_ill_25")]
        public string chr_ill_25 { get; set; }

        [CsvField(Name = "IDP:HH_25:chr_ill_25_Other")]
        public string chr_ill_25_Other { get; set; }

        [CsvField(Name = "IDP:HH_25:MUAC_25")]
        public string MUAC_25 { get; set; }

        [CsvField(Name = "IDP:P1")]
        public string P1 { get; set; }

        [CsvField(Name = "IDP:P2")]
        public string P2 { get; set; }

        [CsvField(Name = "IDP:P2_Other")]
        public string P2_Other { get; set; }

        [CsvField(Name = "IDP:P3")]
        public string P3 { get; set; }

        [CsvField(Name = "IDP:P4")]
        public string P4 { get; set; }

        [CsvField(Name = "IDP:P5")]
        public string P5 { get; set; }

        [CsvField(Name = "IDP:P6")]
        public string P6 { get; set; }

        [CsvField(Name = "IDP:P6_Other")]
        public string P6_Other { get; set; }

        [CsvField(Name = "IDP:P9")]
        public string P9 { get; set; }

        [CsvField(Name = "IDP:P10")]
        public string P10 { get; set; }

        [CsvField(Name = "IDP:P11")]
        public string P11 { get; set; }

        [CsvField(Name = "IDP:P12:P12a")]
        public string P12a { get; set; }

        [CsvField(Name = "IDP:P12:P12b")]
        public string P12b { get; set; }

        [CsvField(Name = "IDP:P12:P12c")]
        public string P12c { get; set; }

        [CsvField(Name = "IDP:P13")]
        public string P13 { get; set; }

        [CsvField(Name = "IDP:LA1a")]
        public string LA1a { get; set; }

        [CsvField(Name = "IDP:LA1a_Other")]
        public string LA1a_Other { get; set; }

        [CsvField(Name = "IDP:LA1b")]
        public string LA1b { get; set; }

        [CsvField(Name = "IDP:LA1b_Other")]
        public string LA1b_Other { get; set; }

        [CsvField(Name = "IDP:LA1c")]
        public string LA1c { get; set; }

        [CsvField(Name = "IDP:LA1c_Other")]
        public string LA1c_Other { get; set; }

        [CsvField(Name = "IDP:LA2a")]
        public string LA2a { get; set; }

        [CsvField(Name = "IDP:LA2a_Other")]
        public string LA2a_Other { get; set; }

        [CsvField(Name = "IDP:LA2b")]
        public string LA2b { get; set; }

        [CsvField(Name = "IDP:LA2b_Other")]
        public string LA2b_Other { get; set; }

        [CsvField(Name = "IDP:LA2c")]
        public string LA2c { get; set; }

        [CsvField(Name = "IDP:LA2c_Other")]
        public string LA2c_Other { get; set; }

        [CsvField(Name = "IDP:LA3_A")]
        public string LA3_A { get; set; }

        [CsvField(Name = "IDP:L1:LA3a")]
        public string LA3a { get; set; }

        [CsvField(Name = "IDP:L1:LA3b")]
        public string LA3b { get; set; }

        [CsvField(Name = "IDP:L1:LA3c")]
        public string LA3c { get; set; }

        [CsvField(Name = "IDP:L1:LA3d")]
        public string LA3d { get; set; }

        [CsvField(Name = "IDP:LA3")]
        public string LA3 { get; set; }

        [CsvField(Name = "IDP:LA3_Other")]
        public string LA3_Other { get; set; }

        [CsvField(Name = "IDP:LA2")]
        public string LA2 { get; set; }

        [CsvField(Name = "IDP:L2:LA5a")]
        public string LA5a { get; set; }

        [CsvField(Name = "IDP:L2:LA5b")]
        public string LA5b { get; set; }

        [CsvField(Name = "IDP:L3:LA6a")]
        public string LA6a { get; set; }

        [CsvField(Name = "IDP:L3:LA6b")]
        public string La6b { get; set; }

        [CsvField(Name = "IDP:L3:LA6c")]
        public string LA6c { get; set; }

        [CsvField(Name = "IDP:FS4_1")]
        public string FS4_1 { get; set; }

        [CsvField(Name = "IDP:FS4_2")]
        public string FS4_2 { get; set; }

        [CsvField(Name = "IDP:FS4_3")]
        public string FS4_3 { get; set; }

        [CsvField(Name = "IDP:FS4_4")]
        public string FS4_4 { get; set; }

        [CsvField(Name = "IDP:FS4_5")]
        public string FS4_5 { get; set; }

        [CsvField(Name = "IDP:FS4_6")]
        public string FS4_6 { get; set; }

        [CsvField(Name = "IDP:FS4_7")]
        public string FS4_7 { get; set; }

        [CsvField(Name = "IDP:FS4_8")]
        public string FS4_8 { get; set; }


        [CsvField(Name = "IDP:FS3")]
        public string FS3 { get; set; }

        [CsvField(Name = "IDP:FS6")]
        public string FS6 { get; set; }

        [CsvField(Name = "IDP:FS7")]
        public string FS7 { get; set; }


        [CsvField(Name = "IDP:FS9")]
        public string FS9 { get; set; }

        [CsvField(Name = "IDP:NUT:N1")]
        public string N1 { get; set; }

        [CsvField(Name = "IDP:NUT:N2")]
        public string N2 { get; set; }

        [CsvField(Name = "IDP:NUT:N2a")]
        public string N2a { get; set; }

        [CsvField(Name = "IDP:NUT:N2b")]
        public string N2b { get; set; }

        [CsvField(Name = "IDP:NUT:N3")]
        public string N3 { get; set; }

        [CsvField(Name = "IDP:NUT:N4")]
        public string N4 { get; set; }

        [CsvField(Name = "IDP:NUT:N5")]
        public string N5 { get; set; }

        [CsvField(Name = "IDP:NUT:N5_Other")]
        public string N5_Other { get; set; }

        [CsvField(Name = "IDP:NUT:N6")]
        public string N6 { get; set; }

        [CsvField(Name = "IDP:EDU:E1")]
        public string E1 { get; set; }

        [CsvField(Name = "IDP:EDU:E1a")]
        public string E1a { get; set; }

        [CsvField(Name = "IDP:EDU:E1b")]
        public string E1b { get; set; }

        [CsvField(Name = "IDP:EDU:E2")]
        public string E2 { get; set; }

        [CsvField(Name = "IDP:EDU:E2a")]
        public string E2a { get; set; }

        [CsvField(Name = "IDP:EDU:E2b")]
        public string E2b { get; set; }

        [CsvField(Name = "IDP:EDU:E2c")]
        public string E2c { get; set; }

        [CsvField(Name = "IDP:EDU:E3")]
        public string E3 { get; set; }

        [CsvField(Name = "IDP:EDU:E3_Other")]
        public string E3_Other { get; set; }

        [CsvField(Name = "IDP:SH:SH1")]
        public string SH1 { get; set; }

        [CsvField(Name = "IDP:SH:SH6")]
        public string SH6 { get; set; }

        [CsvField(Name = "IDP:SH:SH7")]
        public string SH7 { get; set; }

        [CsvField(Name = "IDP:SH9")]
        public string SH9 { get; set; }

        [CsvField(Name = "IDP:SH9a")]
        public string SH9a { get; set; }

        [CsvField(Name = "IDP:SH10")]
        public string SH10 { get; set; }

        [CsvField(Name = "IDP:SH11")]
        public string SH11 { get; set; }

        [CsvField(Name = "IDP:SH8")]
        public string SH8 { get; set; }

        [CsvField(Name = "IDP:W1")]
        public string W1 { get; set; }

        [CsvField(Name = "IDP:W2")]
        public string W2 { get; set; }

        [CsvField(Name = "IDP:W7")]
        public string W7 { get; set; }

        [CsvField(Name = "IDP:W5")]
        public string W5 { get; set; }

        [CsvField(Name = "IDP:W3")]
        public string W3 { get; set; }

        [CsvField(Name = "IDP:W3a")]
        public string W3a { get; set; }

        [CsvField(Name = "IDP:W3b")]
        public string W3b { get; set; }

        [CsvField(Name = "IDP:W4")]
        public string W4 { get; set; }

        [CsvField(Name = "IDP:H1")]
        public string H1 { get; set; }

        [CsvField(Name = "IDP:H1a")]
        public string H1a { get; set; }

        [CsvField(Name = "IDP:H1a_Other")]
        public string H1a_Other { get; set; }

        [CsvField(Name = "IDP:H1b")]
        public string H1b { get; set; }

        [CsvField(Name = "IDP:H1b_Other")]
        public string H1b_Other { get; set; }

        [CsvField(Name = "IDP:H1c")]
        public string H1c { get; set; }

        [CsvField(Name = "IDP:H1c_Other")]
        public string H1c_Other { get; set; }

        [CsvField(Name = "IDP:H3")]
        public string H3 { get; set; }

        [CsvField(Name = "IDP:H3a")]
        public string H3a { get; set; }

        [CsvField(Name = "IDP:H4")]
        public string H4 { get; set; }

        [CsvField(Name = "IDP:H4a")]
        public string H4a { get; set; }

        [CsvField(Name = "IDP:H4a_Other")]
        public string H4a_Other { get; set; }

        [CsvField(Name = "IDP:H5")]
        public string H5 { get; set; }

        [CsvField(Name = "IDP:H5_Other")]
        public string H5_Other { get; set; }

        [CsvField(Name = "IDP:IS5")]
        public string IS5 { get; set; }

        [CsvField(Name = "IDP:IS8a")]
        public string IS8a { get; set; }

        [CsvField(Name = "IDP:IS8a_Other")]
        public string IS8a_Other { get; set; }

        [CsvField(Name = "IDP:IS8b")]
        public string IS8b { get; set; }

        [CsvField(Name = "IDP:IS8b_Other")]
        public string IS8b_Other { get; set; }

        [CsvField(Name = "IDP:IS8c")]
        public string IS8c { get; set; }

        [CsvField(Name = "IDP:IS8c_Other")]
        public string IS8c_Other { get; set; }

        [CsvField(Name = "IDP:IS7a")]
        public string IS7a { get; set; }

        [CsvField(Name = "IDP:IS7a_Other")]
        public string IS7a_Other { get; set; }

        [CsvField(Name = "IDP:IS7b")]
        public string IS7b { get; set; }

        [CsvField(Name = "IDP:IS7b_Other")]
        public string IS7b_Other { get; set; }


        [CsvField(Name = "IDP:IS7c")]
        public string IS7c { get; set; }

        [CsvField(Name = "IDP:IS7c_Other")]
        public string IS7c_Other { get; set; }


        [CsvField(Name = "IDP:IS6a")]
        public string IS6a { get; set; }

        [CsvField(Name = "IDP:IS6a_Other")]
        public string IS6a_Other { get; set; }

        [CsvField(Name = "IDP:IS6b")]
        public string IS6b { get; set; }

        [CsvField(Name = "IDP:IS6b_Other")]
        public string IS6b_Other { get; set; }

        [CsvField(Name = "IDP:IS6c")]
        public string IS6c { get; set; }

        [CsvField(Name = "IDP:IS6c_Other")]
        public string IS6c_Other { get; set; }

        [CsvField(Name = "IDP:SH5a")]
        public string SH5a { get; set; }

        [CsvField(Name = "IDP:SH5a_Other")]
        public string SH5a_Other { get; set; }

        [CsvField(Name = "IDP:SH5b")]
        public string SH5b { get; set; }

        [CsvField(Name = "IDP:SH5b_Other")]
        public string SH5b_Other { get; set; }

        [CsvField(Name = "IDP:SH5c")]
        public string SH5c { get; set; }

        [CsvField(Name = "IDP:SH5c_Other")]
        public string SH5c_Other { get; set; }

        [CsvField(Name = "IDP:IC")]
        public string IC { get; set; }

        [CsvField(Name = "meta:instanceID")]
        public string MetaInstanceID { get; set; }




    }
}