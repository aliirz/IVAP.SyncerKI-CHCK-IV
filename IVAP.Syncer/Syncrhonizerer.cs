using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IVAP.Syncer
{
    public class Syncrhonizerer
    {

        /// <summary>
        /// Returns Synced list of IVAP-IV Survey
        /// </summary>
        /// <param name="unsyncedFile"></param>
        /// <returns></returns>
        public List<SyncedIV> SyncIVAPIVSurvey(List<UnsyncedIV> unsyncedFile)
        {
            List<SyncedIV> synced = new List<SyncedIV>();
            try
            {
                foreach (UnsyncedIV u in unsyncedFile)
                {
                    SyncedIV s = AutoMapper.Mapper.Map<UnsyncedIV, SyncedIV>(u);

                    switch (s.GI4)
                    {
                        case "a":
                            s.GI4 = "Male";
                            break;
                        case "b":
                            s.GI4 = "Female";
                            break;
                    }

                    switch (s.IO1)
                    {
                        case "a":
                            s.IO1 = "Yes";
                            break;
                        case "b":
                            s.IO2 = "No";
                            break;
                    }

                    switch (s.IO2)
                    {
                        case "a":
                            s.IO2 = "North Waziristan";
                            break;
                        case "b":
                            s.IO2 = "Orakzai";
                            break;
                        case "c":
                            s.IO2 = "Bajaur";
                            break;
                        case "d":
                            s.IO2 = "Khyber";
                            break;
                        case "e":
                            s.IO2 = "Mohmand";
                            break;
                        case "f":
                            s.IO2 = "Kurrum";
                            break;
                        case "g":
                            s.IO2 = "South Waziristan";
                            break;
                        case "h":
                            s.IO2 = "Peshawar";
                            break;
                        case "i":
                            s.IO2 = "Hangu";
                            break;
                        case "j":
                            s.IO2 = "Kohat";
                            break;
                        case "k":
                            s.IO2 = "Bannu";
                            break;
                        case "l":
                            s.IO2 = "Lakki Marwat";
                            break;
                        case "m":
                            s.IO2 = "DI Khan";
                            break;
                        case "n":
                            s.IO2 = "Tank";
                            break;
                        case "o":
                            s.IO2 = "Other";
                            break;
                    }

                    switch (s.tir)
                    {
                        case "a":
                            s.tir = "Yes";
                            break;
                        case "b":
                            s.tir = "No";
                            break;
                    }

                    switch (s.IO3)
                    {
                        case "a":
                            s.IO3 = "Individiual Threat";
                            break;
                        case "b":
                            s.IO3 = "Threat of insecurity";
                            break;
                        case "c":
                            s.IO3 = "Conflict in the area";
                            break;
                        case "d":
                            s.IO3 = "No economic opportunities  (due to conflict only)";
                            break;
                    }

                    switch (s.GI5a)
                    {
                        case "a":
                            s.GI5a = "Male";
                            break;
                        case "b":
                            s.GI5a = "Female";
                            break;
                    }


                    switch (s.relationship)
                    {
                        case "a":
                            s.relationship = "Head";
                            break;
                        case "b":
                            s.relationship = "Wife/Husband";
                            break;
                        case "c":
                            s.relationship = "Co-Wife";
                            break;
                        case "d":
                            s.relationship = "Daughter/Son";
                            break;
                        case "e":
                            s.relationship = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.relationship = "Grand Child";
                            break;
                        case "g":
                            s.relationship = "Parent";
                            break;
                        case "h":
                            s.relationship = "Parent-in-law";
                            break;
                        case "i":
                            s.relationship = "Brother/ Sister";
                            break;
                        case "j":
                            s.relationship = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.relationship = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.relationship = "Niece/ Nephew";
                            break;
                        case "m":
                            s.relationship = "Other relative";
                            break;
                        case "n":
                            s.relationship = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.relationship = "Not related";
                            break;
                        case "p":
                            s.relationship = "Dont know";
                            break;
                    }
                    switch (s.HL11a)
                    {
                        case "a":
                            s.HL11a = "Yes";
                            break;
                        case "b":
                            s.HL11a = "Yes but not present, at home";
                            break;
                        case "c":
                            s.HL11a = "Yes but lost";
                            break;
                        case "d":
                            s.HL11a = "No";
                            break;
                        case "e":
                            s.HL11a = "No and have applied for NADRA, I have token number";
                            break;
                        case "f":
                            s.HL11a = "Yes but status not updated as widow";
                            break;
                        case "g":
                            s.HL11a = "Computerize NIC";
                            break;
                        case "h":
                            s.HL11a = "Old NIC";
                            break;
                        case "i":
                            s.HL11a = "English CNIC (Overseas)";
                            break;
                    }

                    switch (s.HL12a)
                    {
                        case "a":
                            s.HL12a = "Computerize NIC";
                            break;
                        case "b":
                            s.HL12a = "Old NIC";
                            break;
                        case "c":
                            s.HL12a = "English CNIC(Overseas)";
                            break;
                    }

                    switch (s.GIPA_1)
                    {
                        case "a":
                            s.GIPA_1 = "Peshawar";
                            break;
                        case "b":
                            s.GIPA_1 = "Mardan";
                            break;
                        case "c":
                            s.GIPA_1 = "Charsadda";
                            break;
                        case "d":
                            s.GIPA_1 = "Nowshera";
                            break;
                        case "e":
                            s.GIPA_1 = "Swabi";
                            break;
                        case "f":
                            s.GIPA_1 = "Kohat";
                            break;
                        case "g":
                            s.GIPA_1 = "Hangu";
                            break;
                        case "h":
                            s.GIPA_1 = "Lower Dir";
                            break;
                        case "i":
                            s.GIPA_1 = "Upper Dir";
                            break;
                        case "j":
                            s.GIPA_1 = "Same as origin";
                            break;
                        case "k":
                            s.GIPA_1 = "Out of KP";
                            break;
                        case "l":
                            s.GIPA_1 = "Out of country";
                            break;
                    }

                    switch (s.FH)
                    {
                        case "a":
                            s.FH = "Male headed family";
                            break;
                        case "b":
                            s.FH = "Female headed";
                            break;
                        case "c":
                            s.FH = "Child headed";
                            break;
                    }

                    switch (s.HL3_1)
                    {
                        case "a":
                            s.HL3_1 = "Head";
                            break;
                        case "b":
                            s.HL3_1 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_1 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_1 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_1 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_1 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_1 = "Parent";
                            break;
                        case "h":
                            s.HL3_1 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_1 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_1 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_1 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_1 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_1 = "Other relative";
                            break;
                        case "n":
                            s.HL3_1 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_1 = "Not related";
                            break;
                        case "p":
                            s.HL3_1 = "Dont know";
                            break;
                    }

                    switch (s.HL4_1)
                    {
                        case "a":
                            s.HL4_1 = "Male";
                            break;
                        case "b":
                            s.HL4_1 = "Female";
                            break;
                    }

                    //Sync HL7_1
                    if (s.HL7_1.Contains("a"))
                    {
                        s.HL7_1_a = "None";
                    }
                    if (s.HL7_1.Contains("b"))
                    {
                        s.HL7_1_b = "Seperated Child";
                    }
                    if (s.HL7_1.Contains("c"))
                    {
                        s.HL7_1_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_1.Contains("d"))
                    {
                        s.HL7_1_d = "Physically disabled";
                    }
                    if (s.HL7_1.Contains("e"))
                    {
                        s.HL7_1_e = "Mentally Disabled";
                    }
                    if (s.HL7_1.Contains("f"))
                    {
                        s.HL7_1_f = "Chronically ill";
                    }
                    if (s.HL7_1.Contains("g"))
                    {
                        s.HL7_1_g = "Widow";
                    }
                    if (s.HL7_1.Contains("h"))
                    {
                        s.HL7_1_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_1.Contains("a"))
                    {
                        s.phy_disable_1_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_1.Contains("b"))
                    {
                        s.phy_disable_1_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_1.Contains("c"))
                    {
                        s.phy_disable_1_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_1.Contains("d"))
                    {
                        s.phy_disable_1_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_1.Contains("e"))
                    {
                        s.phy_disable_1_e = "Polio";
                    }
                    if (s.phy_disable_1.Contains("f"))
                    {
                        s.phy_disable_1_f = "Loss of body parts";
                    }
                    if (s.phy_disable_1.Contains("g"))
                    {
                        s.phy_disable_1_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_1.Contains("h"))
                    {
                        s.phy_disable_1_h = "Paralyses";
                    }
                    if (s.phy_disable_1.Contains("i"))
                    {
                        s.phy_disable_1_i = "Dumb";
                    }
                    if (s.phy_disable_1.Contains("j"))
                    {
                        s.phy_disable_1_j = "Others";
                    }

                    //sync chr_ill_1
                    if (s.chr_ill_1.Contains("a"))
                    {
                        s.chr_ill_1_a = "Heart disease";
                    }
                    if (s.chr_ill_1.Contains("b"))
                    {
                        s.chr_ill_1_a = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_1.Contains("c"))
                    {
                        s.chr_ill_1_c = "Kidneys problem";
                    }
                    if (s.chr_ill_1.Contains("d"))
                    {
                        s.chr_ill_1_d = "Epilepsy";
                    }
                    if (s.chr_ill_1.Contains("e"))
                    {
                        s.chr_ill_1_e = "Diabetes";
                    }
                    if (s.chr_ill_1.Contains("f"))
                    {
                        s.chr_ill_1_f = "Arthritis";
                    }
                    if (s.chr_ill_1.Contains("g"))
                    {
                        s.chr_ill_1_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_1.Contains("h"))
                    {
                        s.chr_ill_1_h = "Cancer";
                    }
                    if (s.chr_ill_1.Contains("i"))
                    {
                        s.chr_ill_1_i = "Blooed pressure";
                    }
                    if (s.chr_ill_1.Contains("j"))
                    {
                        s.chr_ill_1_j = "Gyne problem";
                    }
                    if (s.chr_ill_1.Contains("k"))
                    {
                        s.chr_ill_1_h = "Others";
                    }


                    //HH2
                    switch (s.HL3_2)
                    {
                        case "a":
                            s.HL3_2 = "Head";
                            break;
                        case "b":
                            s.HL3_2 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_2 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_2 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_2 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_2 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_2 = "Parent";
                            break;
                        case "h":
                            s.HL3_2 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_2 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_2 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_2 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_2 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_2 = "Other relative";
                            break;
                        case "n":
                            s.HL3_2 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_2 = "Not related";
                            break;
                        case "p":
                            s.HL3_2 = "Dont know";
                            break;
                    }

                    switch (s.HL4_2)
                    {
                        case "a":
                            s.HL4_2 = "Male";
                            break;
                        case "b":
                            s.HL4_2 = "Female";
                            break;
                    }

                    //Sync HL7_2
                    if (s.HL7_2.Contains("a"))
                    {
                        s.HL7_2_a = "None";
                    }
                    if (s.HL7_2.Contains("b"))
                    {
                        s.HL7_2_b = "Seperated Child";
                    }
                    if (s.HL7_2.Contains("c"))
                    {
                        s.HL7_2_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_2.Contains("d"))
                    {
                        s.HL7_2_d = "Physically disabled";
                    }
                    if (s.HL7_2.Contains("e"))
                    {
                        s.HL7_2_e = "Mentally Disabled";
                    }
                    if (s.HL7_2.Contains("f"))
                    {
                        s.HL7_2_f = "Chronically ill";
                    }
                    if (s.HL7_2.Contains("g"))
                    {
                        s.HL7_2_g = "Widow";
                    }
                    if (s.HL7_2.Contains("h"))
                    {
                        s.HL7_2_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_2.Contains("a"))
                    {
                        s.phy_disable_2_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_2.Contains("b"))
                    {
                        s.phy_disable_2_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_2.Contains("c"))
                    {
                        s.phy_disable_2_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_2.Contains("d"))
                    {
                        s.phy_disable_2_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_2.Contains("e"))
                    {
                        s.phy_disable_2_e = "Polio";
                    }
                    if (s.phy_disable_2.Contains("f"))
                    {
                        s.phy_disable_2_f = "Loss of body parts";
                    }
                    if (s.phy_disable_2.Contains("g"))
                    {
                        s.phy_disable_2_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_2.Contains("h"))
                    {
                        s.phy_disable_2_h = "Paralyses";
                    }
                    if (s.phy_disable_2.Contains("i"))
                    {
                        s.phy_disable_2_i = "Dumb";
                    }
                    if (s.phy_disable_2.Contains("j"))
                    {
                        s.phy_disable_2_j = "Others";
                    }

                    //sync chr_ill_1
                    if (s.chr_ill_2.Contains("a"))
                    {
                        s.chr_ill_2_a = "Heart disease";
                    }
                    if (s.chr_ill_2.Contains("b"))
                    {
                        s.chr_ill_2_a = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_2.Contains("c"))
                    {
                        s.chr_ill_2_c = "Kidneys problem";
                    }
                    if (s.chr_ill_2.Contains("d"))
                    {
                        s.chr_ill_2_d = "Epilepsy";
                    }
                    if (s.chr_ill_2.Contains("e"))
                    {
                        s.chr_ill_2_e = "Diabetes";
                    }
                    if (s.chr_ill_2.Contains("f"))
                    {
                        s.chr_ill_2_f = "Arthritis";
                    }
                    if (s.chr_ill_2.Contains("g"))
                    {
                        s.chr_ill_2_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_2.Contains("h"))
                    {
                        s.chr_ill_2_h = "Cancer";
                    }
                    if (s.chr_ill_2.Contains("i"))
                    {
                        s.chr_ill_2_i = "Blooed pressure";
                    }
                    if (s.chr_ill_2.Contains("j"))
                    {
                        s.chr_ill_2_j = "Gyne problem";
                    }
                    if (s.chr_ill_2.Contains("k"))
                    {
                        s.chr_ill_2_h = "Others";
                    }

                    switch (s.MUAC_2)
                    {
                        case "a":
                            s.MUAC_2 = "Red";
                            break;
                        case "b":
                            s.MUAC_2 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_2 = "Green";
                            break;
                        case "d":
                            s.MUAC_2 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_2 = "Parents not allowing";
                            break;
                    }


                    //HH3
                    switch (s.HL3_3)
                    {
                        case "a":
                            s.HL3_3 = "Head";
                            break;
                        case "b":
                            s.HL3_3 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_3 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_3 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_3 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_3 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_3 = "Parent";
                            break;
                        case "h":
                            s.HL3_3 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_3 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_3 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_3 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_3 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_3 = "Other relative";
                            break;
                        case "n":
                            s.HL3_3 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_3 = "Not related";
                            break;
                        case "p":
                            s.HL3_3 = "Dont know";
                            break;
                    }

                    switch (s.HL4_3)
                    {
                        case "a":
                            s.HL4_3 = "Male";
                            break;
                        case "b":
                            s.HL4_3 = "Female";
                            break;
                    }

                    //Sync HL7_3
                    if (s.HL7_3.Contains("a"))
                    {
                        s.HL7_3_a = "None";
                    }
                    if (s.HL7_3.Contains("b"))
                    {
                        s.HL7_3_b = "Seperated Child";
                    }
                    if (s.HL7_3.Contains("c"))
                    {
                        s.HL7_3_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_3.Contains("d"))
                    {
                        s.HL7_3_d = "Physically disabled";
                    }
                    if (s.HL7_3.Contains("e"))
                    {
                        s.HL7_3_e = "Mentally Disabled";
                    }
                    if (s.HL7_3.Contains("f"))
                    {
                        s.HL7_3_f = "Chronically ill";
                    }
                    if (s.HL7_3.Contains("g"))
                    {
                        s.HL7_3_g = "Widow";
                    }
                    if (s.HL7_3.Contains("h"))
                    {
                        s.HL7_3_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_3.Contains("a"))
                    {
                        s.phy_disable_3_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_3.Contains("b"))
                    {
                        s.phy_disable_3_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_3.Contains("c"))
                    {
                        s.phy_disable_3_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_3.Contains("d"))
                    {
                        s.phy_disable_3_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_3.Contains("e"))
                    {
                        s.phy_disable_3_e = "Polio";
                    }
                    if (s.phy_disable_3.Contains("f"))
                    {
                        s.phy_disable_3_f = "Loss of body parts";
                    }
                    if (s.phy_disable_3.Contains("g"))
                    {
                        s.phy_disable_3_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_3.Contains("h"))
                    {
                        s.phy_disable_3_h = "Paralyses";
                    }
                    if (s.phy_disable_3.Contains("i"))
                    {
                        s.phy_disable_3_i = "Dumb";
                    }
                    if (s.phy_disable_3.Contains("j"))
                    {
                        s.phy_disable_3_j = "Others";
                    }

                    //sync chr_ill_3
                    if (s.chr_ill_3.Contains("a"))
                    {
                        s.chr_ill_3_a = "Heart disease";
                    }
                    if (s.chr_ill_3.Contains("b"))
                    {
                        s.chr_ill_3_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_3.Contains("c"))
                    {
                        s.chr_ill_3_c = "Kidneys problem";
                    }
                    if (s.chr_ill_3.Contains("d"))
                    {
                        s.chr_ill_3_d = "Epilepsy";
                    }
                    if (s.chr_ill_3.Contains("e"))
                    {
                        s.chr_ill_3_e = "Diabetes";
                    }
                    if (s.chr_ill_3.Contains("f"))
                    {
                        s.chr_ill_3_f = "Arthritis";
                    }
                    if (s.chr_ill_3.Contains("g"))
                    {
                        s.chr_ill_3_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_3.Contains("h"))
                    {
                        s.chr_ill_3_h = "Cancer";
                    }
                    if (s.chr_ill_3.Contains("i"))
                    {
                        s.chr_ill_3_i = "Blooed pressure";
                    }
                    if (s.chr_ill_3.Contains("j"))
                    {
                        s.chr_ill_3_j = "Gyne problem";
                    }
                    if (s.chr_ill_3.Contains("k"))
                    {
                        s.chr_ill_3_h = "Others";
                    }

                    switch (s.MUAC_3)
                    {
                        case "a":
                            s.MUAC_3 = "Red";
                            break;
                        case "b":
                            s.MUAC_3 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_3 = "Green";
                            break;
                        case "d":
                            s.MUAC_3 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_3 = "Parents not allowing";
                            break;
                    }

                    //HH4
                    switch (s.HL3_4)
                    {
                        case "a":
                            s.HL3_4 = "Head";
                            break;
                        case "b":
                            s.HL3_4 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_4 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_4 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_4 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_4 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_4 = "Parent";
                            break;
                        case "h":
                            s.HL3_4 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_4 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_4 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_4 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_4 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_4 = "Other relative";
                            break;
                        case "n":
                            s.HL3_4 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_4 = "Not related";
                            break;
                        case "p":
                            s.HL3_4 = "Dont know";
                            break;
                    }

                    switch (s.HL4_4)
                    {
                        case "a":
                            s.HL4_4 = "Male";
                            break;
                        case "b":
                            s.HL4_4 = "Female";
                            break;
                    }

                    //Sync HL7_4
                    if (s.HL7_4.Contains("a"))
                    {
                        s.HL7_4_a = "None";
                    }
                    if (s.HL7_4.Contains("b"))
                    {
                        s.HL7_4_b = "Seperated Child";
                    }
                    if (s.HL7_4.Contains("c"))
                    {
                        s.HL7_4_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_4.Contains("d"))
                    {
                        s.HL7_4_d = "Physically disabled";
                    }
                    if (s.HL7_4.Contains("e"))
                    {
                        s.HL7_4_e = "Mentally Disabled";
                    }
                    if (s.HL7_4.Contains("f"))
                    {
                        s.HL7_4_f = "Chronically ill";
                    }
                    if (s.HL7_4.Contains("g"))
                    {
                        s.HL7_4_g = "Widow";
                    }
                    if (s.HL7_4.Contains("h"))
                    {
                        s.HL7_4_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_4.Contains("a"))
                    {
                        s.phy_disable_4_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_4.Contains("b"))
                    {
                        s.phy_disable_4_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_4.Contains("c"))
                    {
                        s.phy_disable_4_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_4.Contains("d"))
                    {
                        s.phy_disable_4_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_4.Contains("e"))
                    {
                        s.phy_disable_4_e = "Polio";
                    }
                    if (s.phy_disable_4.Contains("f"))
                    {
                        s.phy_disable_4_f = "Loss of body parts";
                    }
                    if (s.phy_disable_4.Contains("g"))
                    {
                        s.phy_disable_4_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_4.Contains("h"))
                    {
                        s.phy_disable_4_h = "Paralyses";
                    }
                    if (s.phy_disable_4.Contains("i"))
                    {
                        s.phy_disable_4_i = "Dumb";
                    }
                    if (s.phy_disable_4.Contains("j"))
                    {
                        s.phy_disable_4_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_4.Contains("a"))
                    {
                        s.chr_ill_4_a = "Heart disease";
                    }
                    if (s.chr_ill_4.Contains("b"))
                    {
                        s.chr_ill_4_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_4.Contains("c"))
                    {
                        s.chr_ill_4_c = "Kidneys problem";
                    }
                    if (s.chr_ill_4.Contains("d"))
                    {
                        s.chr_ill_4_d = "Epilepsy";
                    }
                    if (s.chr_ill_4.Contains("e"))
                    {
                        s.chr_ill_4_e = "Diabetes";
                    }
                    if (s.chr_ill_4.Contains("f"))
                    {
                        s.chr_ill_4_f = "Arthritis";
                    }
                    if (s.chr_ill_4.Contains("g"))
                    {
                        s.chr_ill_4_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_4.Contains("h"))
                    {
                        s.chr_ill_4_h = "Cancer";
                    }
                    if (s.chr_ill_4.Contains("i"))
                    {
                        s.chr_ill_4_i = "Blooed pressure";
                    }
                    if (s.chr_ill_4.Contains("j"))
                    {
                        s.chr_ill_4_j = "Gyne problem";
                    }
                    if (s.chr_ill_4.Contains("k"))
                    {
                        s.chr_ill_4_h = "Others";
                    }

                    switch (s.MUAC_4)
                    {
                        case "a":
                            s.MUAC_4 = "Red";
                            break;
                        case "b":
                            s.MUAC_4 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_4 = "Green";
                            break;
                        case "d":
                            s.MUAC_4 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_4 = "Parents not allowing";
                            break;
                    }


                    #region FamilyMember
                    switch (s.HL3_5)
                    {
                        case "a":
                            s.HL3_5 = "Head";
                            break;
                        case "b":
                            s.HL3_5 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_5 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_5 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_5 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_5 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_5 = "Parent";
                            break;
                        case "h":
                            s.HL3_5 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_5 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_5 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_5 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_5 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_5 = "Other relative";
                            break;
                        case "n":
                            s.HL3_5 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_5 = "Not related";
                            break;
                        case "p":
                            s.HL3_5 = "Dont know";
                            break;
                    }

                    switch (s.HL4_5)
                    {
                        case "a":
                            s.HL4_5 = "Male";
                            break;
                        case "b":
                            s.HL4_5 = "Female";
                            break;
                    }


                    if (s.HL7_5.Contains("a"))
                    {
                        s.HL7_5_a = "None";
                    }
                    if (s.HL7_5.Contains("b"))
                    {
                        s.HL7_5_b = "Seperated Child";
                    }
                    if (s.HL7_5.Contains("c"))
                    {
                        s.HL7_5_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_5.Contains("d"))
                    {
                        s.HL7_5_d = "Physically disabled";
                    }
                    if (s.HL7_5.Contains("e"))
                    {
                        s.HL7_5_e = "Mentally Disabled";
                    }
                    if (s.HL7_5.Contains("f"))
                    {
                        s.HL7_5_f = "Chronically ill";
                    }
                    if (s.HL7_5.Contains("g"))
                    {
                        s.HL7_5_g = "Widow";
                    }
                    if (s.HL7_5.Contains("h"))
                    {
                        s.HL7_5_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_5.Contains("a"))
                    {
                        s.phy_disable_5_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_5.Contains("b"))
                    {
                        s.phy_disable_5_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_5.Contains("c"))
                    {
                        s.phy_disable_5_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_5.Contains("d"))
                    {
                        s.phy_disable_5_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_5.Contains("e"))
                    {
                        s.phy_disable_5_e = "Polio";
                    }
                    if (s.phy_disable_5.Contains("f"))
                    {
                        s.phy_disable_5_f = "Loss of body parts";
                    }
                    if (s.phy_disable_5.Contains("g"))
                    {
                        s.phy_disable_5_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_5.Contains("h"))
                    {
                        s.phy_disable_5_h = "Paralyses";
                    }
                    if (s.phy_disable_5.Contains("i"))
                    {
                        s.phy_disable_5_i = "Dumb";
                    }
                    if (s.phy_disable_5.Contains("j"))
                    {
                        s.phy_disable_5_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_5.Contains("a"))
                    {
                        s.chr_ill_5_a = "Heart disease";
                    }
                    if (s.chr_ill_5.Contains("b"))
                    {
                        s.chr_ill_5_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_5.Contains("c"))
                    {
                        s.chr_ill_5_c = "Kidneys problem";
                    }
                    if (s.chr_ill_5.Contains("d"))
                    {
                        s.chr_ill_5_d = "Epilepsy";
                    }
                    if (s.chr_ill_5.Contains("e"))
                    {
                        s.chr_ill_5_e = "Diabetes";
                    }
                    if (s.chr_ill_5.Contains("f"))
                    {
                        s.chr_ill_5_f = "Arthritis";
                    }
                    if (s.chr_ill_5.Contains("g"))
                    {
                        s.chr_ill_5_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_5.Contains("h"))
                    {
                        s.chr_ill_5_h = "Cancer";
                    }
                    if (s.chr_ill_5.Contains("i"))
                    {
                        s.chr_ill_5_i = "Blooed pressure";
                    }
                    if (s.chr_ill_5.Contains("j"))
                    {
                        s.chr_ill_5_j = "Gyne problem";
                    }
                    if (s.chr_ill_5.Contains("k"))
                    {
                        s.chr_ill_5_h = "Others";
                    }

                    switch (s.MUAC_5)
                    {
                        case "a":
                            s.MUAC_5 = "Red";
                            break;
                        case "b":
                            s.MUAC_5 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_5 = "Green";
                            break;
                        case "d":
                            s.MUAC_5 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_5 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_6)
                    {
                        case "a":
                            s.HL3_6 = "Head";
                            break;
                        case "b":
                            s.HL3_6 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_6 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_6 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_6 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_6 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_6 = "Parent";
                            break;
                        case "h":
                            s.HL3_6 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_6 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_6 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_6 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_6 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_6 = "Other relative";
                            break;
                        case "n":
                            s.HL3_6 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_6 = "Not related";
                            break;
                        case "p":
                            s.HL3_6 = "Dont know";
                            break;
                    }

                    switch (s.HL4_6)
                    {
                        case "a":
                            s.HL4_6 = "Male";
                            break;
                        case "b":
                            s.HL4_6 = "Female";
                            break;
                    }


                    if (s.HL7_6.Contains("a"))
                    {
                        s.HL7_6_a = "None";
                    }
                    if (s.HL7_6.Contains("b"))
                    {
                        s.HL7_6_b = "Seperated Child";
                    }
                    if (s.HL7_6.Contains("c"))
                    {
                        s.HL7_6_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_6.Contains("d"))
                    {
                        s.HL7_6_d = "Physically disabled";
                    }
                    if (s.HL7_6.Contains("e"))
                    {
                        s.HL7_6_e = "Mentally Disabled";
                    }
                    if (s.HL7_6.Contains("f"))
                    {
                        s.HL7_6_f = "Chronically ill";
                    }
                    if (s.HL7_6.Contains("g"))
                    {
                        s.HL7_6_g = "Widow";
                    }
                    if (s.HL7_6.Contains("h"))
                    {
                        s.HL7_6_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_6.Contains("a"))
                    {
                        s.phy_disable_6_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_6.Contains("b"))
                    {
                        s.phy_disable_6_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_6.Contains("c"))
                    {
                        s.phy_disable_6_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_6.Contains("d"))
                    {
                        s.phy_disable_6_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_6.Contains("e"))
                    {
                        s.phy_disable_6_e = "Polio";
                    }
                    if (s.phy_disable_6.Contains("f"))
                    {
                        s.phy_disable_6_f = "Loss of body parts";
                    }
                    if (s.phy_disable_6.Contains("g"))
                    {
                        s.phy_disable_6_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_6.Contains("h"))
                    {
                        s.phy_disable_6_h = "Paralyses";
                    }
                    if (s.phy_disable_6.Contains("i"))
                    {
                        s.phy_disable_6_i = "Dumb";
                    }
                    if (s.phy_disable_6.Contains("j"))
                    {
                        s.phy_disable_6_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_6.Contains("a"))
                    {
                        s.chr_ill_6_a = "Heart disease";
                    }
                    if (s.chr_ill_6.Contains("b"))
                    {
                        s.chr_ill_6_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_6.Contains("c"))
                    {
                        s.chr_ill_6_c = "Kidneys problem";
                    }
                    if (s.chr_ill_6.Contains("d"))
                    {
                        s.chr_ill_6_d = "Epilepsy";
                    }
                    if (s.chr_ill_6.Contains("e"))
                    {
                        s.chr_ill_6_e = "Diabetes";
                    }
                    if (s.chr_ill_6.Contains("f"))
                    {
                        s.chr_ill_6_f = "Arthritis";
                    }
                    if (s.chr_ill_6.Contains("g"))
                    {
                        s.chr_ill_6_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_6.Contains("h"))
                    {
                        s.chr_ill_6_h = "Cancer";
                    }
                    if (s.chr_ill_6.Contains("i"))
                    {
                        s.chr_ill_6_i = "Blooed pressure";
                    }
                    if (s.chr_ill_6.Contains("j"))
                    {
                        s.chr_ill_6_j = "Gyne problem";
                    }
                    if (s.chr_ill_6.Contains("k"))
                    {
                        s.chr_ill_6_h = "Others";
                    }

                    switch (s.MUAC_6)
                    {
                        case "a":
                            s.MUAC_6 = "Red";
                            break;
                        case "b":
                            s.MUAC_6 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_6 = "Green";
                            break;
                        case "d":
                            s.MUAC_6 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_6 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_7)
                    {
                        case "a":
                            s.HL3_7 = "Head";
                            break;
                        case "b":
                            s.HL3_7 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_7 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_7 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_7 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_7 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_7 = "Parent";
                            break;
                        case "h":
                            s.HL3_7 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_7 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_7 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_7 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_7 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_7 = "Other relative";
                            break;
                        case "n":
                            s.HL3_7 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_7 = "Not related";
                            break;
                        case "p":
                            s.HL3_7 = "Dont know";
                            break;
                    }

                    switch (s.HL4_7)
                    {
                        case "a":
                            s.HL4_7 = "Male";
                            break;
                        case "b":
                            s.HL4_7 = "Female";
                            break;
                    }


                    if (s.HL7_7.Contains("a"))
                    {
                        s.HL7_7_a = "None";
                    }
                    if (s.HL7_7.Contains("b"))
                    {
                        s.HL7_7_b = "Seperated Child";
                    }
                    if (s.HL7_7.Contains("c"))
                    {
                        s.HL7_7_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_7.Contains("d"))
                    {
                        s.HL7_7_d = "Physically disabled";
                    }
                    if (s.HL7_7.Contains("e"))
                    {
                        s.HL7_7_e = "Mentally Disabled";
                    }
                    if (s.HL7_7.Contains("f"))
                    {
                        s.HL7_7_f = "Chronically ill";
                    }
                    if (s.HL7_7.Contains("g"))
                    {
                        s.HL7_7_g = "Widow";
                    }
                    if (s.HL7_7.Contains("h"))
                    {
                        s.HL7_7_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_7.Contains("a"))
                    {
                        s.phy_disable_7_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_7.Contains("b"))
                    {
                        s.phy_disable_7_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_7.Contains("c"))
                    {
                        s.phy_disable_7_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_7.Contains("d"))
                    {
                        s.phy_disable_7_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_7.Contains("e"))
                    {
                        s.phy_disable_7_e = "Polio";
                    }
                    if (s.phy_disable_7.Contains("f"))
                    {
                        s.phy_disable_7_f = "Loss of body parts";
                    }
                    if (s.phy_disable_7.Contains("g"))
                    {
                        s.phy_disable_7_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_7.Contains("h"))
                    {
                        s.phy_disable_7_h = "Paralyses";
                    }
                    if (s.phy_disable_7.Contains("i"))
                    {
                        s.phy_disable_7_i = "Dumb";
                    }
                    if (s.phy_disable_7.Contains("j"))
                    {
                        s.phy_disable_7_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_7.Contains("a"))
                    {
                        s.chr_ill_7_a = "Heart disease";
                    }
                    if (s.chr_ill_7.Contains("b"))
                    {
                        s.chr_ill_7_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_7.Contains("c"))
                    {
                        s.chr_ill_7_c = "Kidneys problem";
                    }
                    if (s.chr_ill_7.Contains("d"))
                    {
                        s.chr_ill_7_d = "Epilepsy";
                    }
                    if (s.chr_ill_7.Contains("e"))
                    {
                        s.chr_ill_7_e = "Diabetes";
                    }
                    if (s.chr_ill_7.Contains("f"))
                    {
                        s.chr_ill_7_f = "Arthritis";
                    }
                    if (s.chr_ill_7.Contains("g"))
                    {
                        s.chr_ill_7_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_7.Contains("h"))
                    {
                        s.chr_ill_7_h = "Cancer";
                    }
                    if (s.chr_ill_7.Contains("i"))
                    {
                        s.chr_ill_7_i = "Blooed pressure";
                    }
                    if (s.chr_ill_7.Contains("j"))
                    {
                        s.chr_ill_7_j = "Gyne problem";
                    }
                    if (s.chr_ill_7.Contains("k"))
                    {
                        s.chr_ill_7_h = "Others";
                    }

                    switch (s.MUAC_7)
                    {
                        case "a":
                            s.MUAC_7 = "Red";
                            break;
                        case "b":
                            s.MUAC_7 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_7 = "Green";
                            break;
                        case "d":
                            s.MUAC_7 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_7 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_8)
                    {
                        case "a":
                            s.HL3_8 = "Head";
                            break;
                        case "b":
                            s.HL3_8 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_8 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_8 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_8 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_8 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_8 = "Parent";
                            break;
                        case "h":
                            s.HL3_8 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_8 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_8 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_8 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_8 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_8 = "Other relative";
                            break;
                        case "n":
                            s.HL3_8 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_8 = "Not related";
                            break;
                        case "p":
                            s.HL3_8 = "Dont know";
                            break;
                    }

                    switch (s.HL4_8)
                    {
                        case "a":
                            s.HL4_8 = "Male";
                            break;
                        case "b":
                            s.HL4_8 = "Female";
                            break;
                    }


                    if (s.HL7_8.Contains("a"))
                    {
                        s.HL7_8_a = "None";
                    }
                    if (s.HL7_8.Contains("b"))
                    {
                        s.HL7_8_b = "Seperated Child";
                    }
                    if (s.HL7_8.Contains("c"))
                    {
                        s.HL7_8_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_8.Contains("d"))
                    {
                        s.HL7_8_d = "Physically disabled";
                    }
                    if (s.HL7_8.Contains("e"))
                    {
                        s.HL7_8_e = "Mentally Disabled";
                    }
                    if (s.HL7_8.Contains("f"))
                    {
                        s.HL7_8_f = "Chronically ill";
                    }
                    if (s.HL7_8.Contains("g"))
                    {
                        s.HL7_8_g = "Widow";
                    }
                    if (s.HL7_8.Contains("h"))
                    {
                        s.HL7_8_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_8.Contains("a"))
                    {
                        s.phy_disable_8_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_8.Contains("b"))
                    {
                        s.phy_disable_8_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_8.Contains("c"))
                    {
                        s.phy_disable_8_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_8.Contains("d"))
                    {
                        s.phy_disable_8_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_8.Contains("e"))
                    {
                        s.phy_disable_8_e = "Polio";
                    }
                    if (s.phy_disable_8.Contains("f"))
                    {
                        s.phy_disable_8_f = "Loss of body parts";
                    }
                    if (s.phy_disable_8.Contains("g"))
                    {
                        s.phy_disable_8_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_8.Contains("h"))
                    {
                        s.phy_disable_8_h = "Paralyses";
                    }
                    if (s.phy_disable_8.Contains("i"))
                    {
                        s.phy_disable_8_i = "Dumb";
                    }
                    if (s.phy_disable_8.Contains("j"))
                    {
                        s.phy_disable_8_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_8.Contains("a"))
                    {
                        s.chr_ill_8_a = "Heart disease";
                    }
                    if (s.chr_ill_8.Contains("b"))
                    {
                        s.chr_ill_8_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_8.Contains("c"))
                    {
                        s.chr_ill_8_c = "Kidneys problem";
                    }
                    if (s.chr_ill_8.Contains("d"))
                    {
                        s.chr_ill_8_d = "Epilepsy";
                    }
                    if (s.chr_ill_8.Contains("e"))
                    {
                        s.chr_ill_8_e = "Diabetes";
                    }
                    if (s.chr_ill_8.Contains("f"))
                    {
                        s.chr_ill_8_f = "Arthritis";
                    }
                    if (s.chr_ill_8.Contains("g"))
                    {
                        s.chr_ill_8_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_8.Contains("h"))
                    {
                        s.chr_ill_8_h = "Cancer";
                    }
                    if (s.chr_ill_8.Contains("i"))
                    {
                        s.chr_ill_8_i = "Blooed pressure";
                    }
                    if (s.chr_ill_8.Contains("j"))
                    {
                        s.chr_ill_8_j = "Gyne problem";
                    }
                    if (s.chr_ill_8.Contains("k"))
                    {
                        s.chr_ill_8_h = "Others";
                    }

                    switch (s.MUAC_8)
                    {
                        case "a":
                            s.MUAC_8 = "Red";
                            break;
                        case "b":
                            s.MUAC_8 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_8 = "Green";
                            break;
                        case "d":
                            s.MUAC_8 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_8 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_9)
                    {
                        case "a":
                            s.HL3_9 = "Head";
                            break;
                        case "b":
                            s.HL3_9 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_9 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_9 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_9 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_9 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_9 = "Parent";
                            break;
                        case "h":
                            s.HL3_9 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_9 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_9 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_9 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_9 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_9 = "Other relative";
                            break;
                        case "n":
                            s.HL3_9 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_9 = "Not related";
                            break;
                        case "p":
                            s.HL3_9 = "Dont know";
                            break;
                    }

                    switch (s.HL4_9)
                    {
                        case "a":
                            s.HL4_9 = "Male";
                            break;
                        case "b":
                            s.HL4_9 = "Female";
                            break;
                    }


                    if (s.HL7_9.Contains("a"))
                    {
                        s.HL7_9_a = "None";
                    }
                    if (s.HL7_9.Contains("b"))
                    {
                        s.HL7_9_b = "Seperated Child";
                    }
                    if (s.HL7_9.Contains("c"))
                    {
                        s.HL7_9_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_9.Contains("d"))
                    {
                        s.HL7_9_d = "Physically disabled";
                    }
                    if (s.HL7_9.Contains("e"))
                    {
                        s.HL7_9_e = "Mentally Disabled";
                    }
                    if (s.HL7_9.Contains("f"))
                    {
                        s.HL7_9_f = "Chronically ill";
                    }
                    if (s.HL7_9.Contains("g"))
                    {
                        s.HL7_9_g = "Widow";
                    }
                    if (s.HL7_9.Contains("h"))
                    {
                        s.HL7_9_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_9.Contains("a"))
                    {
                        s.phy_disable_9_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_9.Contains("b"))
                    {
                        s.phy_disable_9_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_9.Contains("c"))
                    {
                        s.phy_disable_9_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_9.Contains("d"))
                    {
                        s.phy_disable_9_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_9.Contains("e"))
                    {
                        s.phy_disable_9_e = "Polio";
                    }
                    if (s.phy_disable_9.Contains("f"))
                    {
                        s.phy_disable_9_f = "Loss of body parts";
                    }
                    if (s.phy_disable_9.Contains("g"))
                    {
                        s.phy_disable_9_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_9.Contains("h"))
                    {
                        s.phy_disable_9_h = "Paralyses";
                    }
                    if (s.phy_disable_9.Contains("i"))
                    {
                        s.phy_disable_9_i = "Dumb";
                    }
                    if (s.phy_disable_9.Contains("j"))
                    {
                        s.phy_disable_9_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_9.Contains("a"))
                    {
                        s.chr_ill_9_a = "Heart disease";
                    }
                    if (s.chr_ill_9.Contains("b"))
                    {
                        s.chr_ill_9_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_9.Contains("c"))
                    {
                        s.chr_ill_9_c = "Kidneys problem";
                    }
                    if (s.chr_ill_9.Contains("d"))
                    {
                        s.chr_ill_9_d = "Epilepsy";
                    }
                    if (s.chr_ill_9.Contains("e"))
                    {
                        s.chr_ill_9_e = "Diabetes";
                    }
                    if (s.chr_ill_9.Contains("f"))
                    {
                        s.chr_ill_9_f = "Arthritis";
                    }
                    if (s.chr_ill_9.Contains("g"))
                    {
                        s.chr_ill_9_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_9.Contains("h"))
                    {
                        s.chr_ill_9_h = "Cancer";
                    }
                    if (s.chr_ill_9.Contains("i"))
                    {
                        s.chr_ill_9_i = "Blooed pressure";
                    }
                    if (s.chr_ill_9.Contains("j"))
                    {
                        s.chr_ill_9_j = "Gyne problem";
                    }
                    if (s.chr_ill_9.Contains("k"))
                    {
                        s.chr_ill_9_h = "Others";
                    }

                    switch (s.MUAC_9)
                    {
                        case "a":
                            s.MUAC_9 = "Red";
                            break;
                        case "b":
                            s.MUAC_9 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_9 = "Green";
                            break;
                        case "d":
                            s.MUAC_9 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_9 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_10)
                    {
                        case "a":
                            s.HL3_10 = "Head";
                            break;
                        case "b":
                            s.HL3_10 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_10 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_10 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_10 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_10 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_10 = "Parent";
                            break;
                        case "h":
                            s.HL3_10 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_10 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_10 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_10 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_10 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_10 = "Other relative";
                            break;
                        case "n":
                            s.HL3_10 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_10 = "Not related";
                            break;
                        case "p":
                            s.HL3_10 = "Dont know";
                            break;
                    }

                    switch (s.HL4_10)
                    {
                        case "a":
                            s.HL4_10 = "Male";
                            break;
                        case "b":
                            s.HL4_10 = "Female";
                            break;
                    }


                    if (s.HL7_10.Contains("a"))
                    {
                        s.HL7_10_a = "None";
                    }
                    if (s.HL7_10.Contains("b"))
                    {
                        s.HL7_10_b = "Seperated Child";
                    }
                    if (s.HL7_10.Contains("c"))
                    {
                        s.HL7_10_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_10.Contains("d"))
                    {
                        s.HL7_10_d = "Physically disabled";
                    }
                    if (s.HL7_10.Contains("e"))
                    {
                        s.HL7_10_e = "Mentally Disabled";
                    }
                    if (s.HL7_10.Contains("f"))
                    {
                        s.HL7_10_f = "Chronically ill";
                    }
                    if (s.HL7_10.Contains("g"))
                    {
                        s.HL7_10_g = "Widow";
                    }
                    if (s.HL7_10.Contains("h"))
                    {
                        s.HL7_10_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_10.Contains("a"))
                    {
                        s.phy_disable_10_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_10.Contains("b"))
                    {
                        s.phy_disable_10_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_10.Contains("c"))
                    {
                        s.phy_disable_10_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_10.Contains("d"))
                    {
                        s.phy_disable_10_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_10.Contains("e"))
                    {
                        s.phy_disable_10_e = "Polio";
                    }
                    if (s.phy_disable_10.Contains("f"))
                    {
                        s.phy_disable_10_f = "Loss of body parts";
                    }
                    if (s.phy_disable_10.Contains("g"))
                    {
                        s.phy_disable_10_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_10.Contains("h"))
                    {
                        s.phy_disable_10_h = "Paralyses";
                    }
                    if (s.phy_disable_10.Contains("i"))
                    {
                        s.phy_disable_10_i = "Dumb";
                    }
                    if (s.phy_disable_10.Contains("j"))
                    {
                        s.phy_disable_10_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_10.Contains("a"))
                    {
                        s.chr_ill_10_a = "Heart disease";
                    }
                    if (s.chr_ill_10.Contains("b"))
                    {
                        s.chr_ill_10_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_10.Contains("c"))
                    {
                        s.chr_ill_10_c = "Kidneys problem";
                    }
                    if (s.chr_ill_10.Contains("d"))
                    {
                        s.chr_ill_10_d = "Epilepsy";
                    }
                    if (s.chr_ill_10.Contains("e"))
                    {
                        s.chr_ill_10_e = "Diabetes";
                    }
                    if (s.chr_ill_10.Contains("f"))
                    {
                        s.chr_ill_10_f = "Arthritis";
                    }
                    if (s.chr_ill_10.Contains("g"))
                    {
                        s.chr_ill_10_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_10.Contains("h"))
                    {
                        s.chr_ill_10_h = "Cancer";
                    }
                    if (s.chr_ill_10.Contains("i"))
                    {
                        s.chr_ill_10_i = "Blooed pressure";
                    }
                    if (s.chr_ill_10.Contains("j"))
                    {
                        s.chr_ill_10_j = "Gyne problem";
                    }
                    if (s.chr_ill_10.Contains("k"))
                    {
                        s.chr_ill_10_h = "Others";
                    }

                    switch (s.MUAC_10)
                    {
                        case "a":
                            s.MUAC_10 = "Red";
                            break;
                        case "b":
                            s.MUAC_10 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_10 = "Green";
                            break;
                        case "d":
                            s.MUAC_10 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_10 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_11)
                    {
                        case "a":
                            s.HL3_11 = "Head";
                            break;
                        case "b":
                            s.HL3_11 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_11 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_11 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_11 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_11 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_11 = "Parent";
                            break;
                        case "h":
                            s.HL3_11 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_11 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_11 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_11 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_11 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_11 = "Other relative";
                            break;
                        case "n":
                            s.HL3_11 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_11 = "Not related";
                            break;
                        case "p":
                            s.HL3_11 = "Dont know";
                            break;
                    }

                    switch (s.HL4_11)
                    {
                        case "a":
                            s.HL4_11 = "Male";
                            break;
                        case "b":
                            s.HL4_11 = "Female";
                            break;
                    }


                    if (s.HL7_11.Contains("a"))
                    {
                        s.HL7_11_a = "None";
                    }
                    if (s.HL7_11.Contains("b"))
                    {
                        s.HL7_11_b = "Seperated Child";
                    }
                    if (s.HL7_11.Contains("c"))
                    {
                        s.HL7_11_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_11.Contains("d"))
                    {
                        s.HL7_11_d = "Physically disabled";
                    }
                    if (s.HL7_11.Contains("e"))
                    {
                        s.HL7_11_e = "Mentally Disabled";
                    }
                    if (s.HL7_11.Contains("f"))
                    {
                        s.HL7_11_f = "Chronically ill";
                    }
                    if (s.HL7_11.Contains("g"))
                    {
                        s.HL7_11_g = "Widow";
                    }
                    if (s.HL7_11.Contains("h"))
                    {
                        s.HL7_11_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_11.Contains("a"))
                    {
                        s.phy_disable_11_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_11.Contains("b"))
                    {
                        s.phy_disable_11_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_11.Contains("c"))
                    {
                        s.phy_disable_11_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_11.Contains("d"))
                    {
                        s.phy_disable_11_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_11.Contains("e"))
                    {
                        s.phy_disable_11_e = "Polio";
                    }
                    if (s.phy_disable_11.Contains("f"))
                    {
                        s.phy_disable_11_f = "Loss of body parts";
                    }
                    if (s.phy_disable_11.Contains("g"))
                    {
                        s.phy_disable_11_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_11.Contains("h"))
                    {
                        s.phy_disable_11_h = "Paralyses";
                    }
                    if (s.phy_disable_11.Contains("i"))
                    {
                        s.phy_disable_11_i = "Dumb";
                    }
                    if (s.phy_disable_11.Contains("j"))
                    {
                        s.phy_disable_11_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_11.Contains("a"))
                    {
                        s.chr_ill_11_a = "Heart disease";
                    }
                    if (s.chr_ill_11.Contains("b"))
                    {
                        s.chr_ill_11_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_11.Contains("c"))
                    {
                        s.chr_ill_11_c = "Kidneys problem";
                    }
                    if (s.chr_ill_11.Contains("d"))
                    {
                        s.chr_ill_11_d = "Epilepsy";
                    }
                    if (s.chr_ill_11.Contains("e"))
                    {
                        s.chr_ill_11_e = "Diabetes";
                    }
                    if (s.chr_ill_11.Contains("f"))
                    {
                        s.chr_ill_11_f = "Arthritis";
                    }
                    if (s.chr_ill_11.Contains("g"))
                    {
                        s.chr_ill_11_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_11.Contains("h"))
                    {
                        s.chr_ill_11_h = "Cancer";
                    }
                    if (s.chr_ill_11.Contains("i"))
                    {
                        s.chr_ill_11_i = "Blooed pressure";
                    }
                    if (s.chr_ill_11.Contains("j"))
                    {
                        s.chr_ill_11_j = "Gyne problem";
                    }
                    if (s.chr_ill_11.Contains("k"))
                    {
                        s.chr_ill_11_h = "Others";
                    }

                    switch (s.MUAC_11)
                    {
                        case "a":
                            s.MUAC_11 = "Red";
                            break;
                        case "b":
                            s.MUAC_11 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_11 = "Green";
                            break;
                        case "d":
                            s.MUAC_11 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_11 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_12)
                    {
                        case "a":
                            s.HL3_12 = "Head";
                            break;
                        case "b":
                            s.HL3_12 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_12 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_12 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_12 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_12 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_12 = "Parent";
                            break;
                        case "h":
                            s.HL3_12 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_12 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_12 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_12 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_12 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_12 = "Other relative";
                            break;
                        case "n":
                            s.HL3_12 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_12 = "Not related";
                            break;
                        case "p":
                            s.HL3_12 = "Dont know";
                            break;
                    }

                    switch (s.HL4_12)
                    {
                        case "a":
                            s.HL4_12 = "Male";
                            break;
                        case "b":
                            s.HL4_12 = "Female";
                            break;
                    }


                    if (s.HL7_12.Contains("a"))
                    {
                        s.HL7_12_a = "None";
                    }
                    if (s.HL7_12.Contains("b"))
                    {
                        s.HL7_12_b = "Seperated Child";
                    }
                    if (s.HL7_12.Contains("c"))
                    {
                        s.HL7_12_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_12.Contains("d"))
                    {
                        s.HL7_12_d = "Physically disabled";
                    }
                    if (s.HL7_12.Contains("e"))
                    {
                        s.HL7_12_e = "Mentally Disabled";
                    }
                    if (s.HL7_12.Contains("f"))
                    {
                        s.HL7_12_f = "Chronically ill";
                    }
                    if (s.HL7_12.Contains("g"))
                    {
                        s.HL7_12_g = "Widow";
                    }
                    if (s.HL7_12.Contains("h"))
                    {
                        s.HL7_12_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_12.Contains("a"))
                    {
                        s.phy_disable_12_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_12.Contains("b"))
                    {
                        s.phy_disable_12_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_12.Contains("c"))
                    {
                        s.phy_disable_12_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_12.Contains("d"))
                    {
                        s.phy_disable_12_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_12.Contains("e"))
                    {
                        s.phy_disable_12_e = "Polio";
                    }
                    if (s.phy_disable_12.Contains("f"))
                    {
                        s.phy_disable_12_f = "Loss of body parts";
                    }
                    if (s.phy_disable_12.Contains("g"))
                    {
                        s.phy_disable_12_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_12.Contains("h"))
                    {
                        s.phy_disable_12_h = "Paralyses";
                    }
                    if (s.phy_disable_12.Contains("i"))
                    {
                        s.phy_disable_12_i = "Dumb";
                    }
                    if (s.phy_disable_12.Contains("j"))
                    {
                        s.phy_disable_12_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_12.Contains("a"))
                    {
                        s.chr_ill_12_a = "Heart disease";
                    }
                    if (s.chr_ill_12.Contains("b"))
                    {
                        s.chr_ill_12_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_12.Contains("c"))
                    {
                        s.chr_ill_12_c = "Kidneys problem";
                    }
                    if (s.chr_ill_12.Contains("d"))
                    {
                        s.chr_ill_12_d = "Epilepsy";
                    }
                    if (s.chr_ill_12.Contains("e"))
                    {
                        s.chr_ill_12_e = "Diabetes";
                    }
                    if (s.chr_ill_12.Contains("f"))
                    {
                        s.chr_ill_12_f = "Arthritis";
                    }
                    if (s.chr_ill_12.Contains("g"))
                    {
                        s.chr_ill_12_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_12.Contains("h"))
                    {
                        s.chr_ill_12_h = "Cancer";
                    }
                    if (s.chr_ill_12.Contains("i"))
                    {
                        s.chr_ill_12_i = "Blooed pressure";
                    }
                    if (s.chr_ill_12.Contains("j"))
                    {
                        s.chr_ill_12_j = "Gyne problem";
                    }
                    if (s.chr_ill_12.Contains("k"))
                    {
                        s.chr_ill_12_h = "Others";
                    }

                    switch (s.MUAC_12)
                    {
                        case "a":
                            s.MUAC_12 = "Red";
                            break;
                        case "b":
                            s.MUAC_12 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_12 = "Green";
                            break;
                        case "d":
                            s.MUAC_12 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_12 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_13)
                    {
                        case "a":
                            s.HL3_13 = "Head";
                            break;
                        case "b":
                            s.HL3_13 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_13 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_13 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_13 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_13 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_13 = "Parent";
                            break;
                        case "h":
                            s.HL3_13 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_13 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_13 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_13 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_13 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_13 = "Other relative";
                            break;
                        case "n":
                            s.HL3_13 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_13 = "Not related";
                            break;
                        case "p":
                            s.HL3_13 = "Dont know";
                            break;
                    }

                    switch (s.HL4_13)
                    {
                        case "a":
                            s.HL4_13 = "Male";
                            break;
                        case "b":
                            s.HL4_13 = "Female";
                            break;
                    }


                    if (s.HL7_13.Contains("a"))
                    {
                        s.HL7_13_a = "None";
                    }
                    if (s.HL7_13.Contains("b"))
                    {
                        s.HL7_13_b = "Seperated Child";
                    }
                    if (s.HL7_13.Contains("c"))
                    {
                        s.HL7_13_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_13.Contains("d"))
                    {
                        s.HL7_13_d = "Physically disabled";
                    }
                    if (s.HL7_13.Contains("e"))
                    {
                        s.HL7_13_e = "Mentally Disabled";
                    }
                    if (s.HL7_13.Contains("f"))
                    {
                        s.HL7_13_f = "Chronically ill";
                    }
                    if (s.HL7_13.Contains("g"))
                    {
                        s.HL7_13_g = "Widow";
                    }
                    if (s.HL7_13.Contains("h"))
                    {
                        s.HL7_13_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_13.Contains("a"))
                    {
                        s.phy_disable_13_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_13.Contains("b"))
                    {
                        s.phy_disable_13_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_13.Contains("c"))
                    {
                        s.phy_disable_13_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_13.Contains("d"))
                    {
                        s.phy_disable_13_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_13.Contains("e"))
                    {
                        s.phy_disable_13_e = "Polio";
                    }
                    if (s.phy_disable_13.Contains("f"))
                    {
                        s.phy_disable_13_f = "Loss of body parts";
                    }
                    if (s.phy_disable_13.Contains("g"))
                    {
                        s.phy_disable_13_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_13.Contains("h"))
                    {
                        s.phy_disable_13_h = "Paralyses";
                    }
                    if (s.phy_disable_13.Contains("i"))
                    {
                        s.phy_disable_13_i = "Dumb";
                    }
                    if (s.phy_disable_13.Contains("j"))
                    {
                        s.phy_disable_13_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_13.Contains("a"))
                    {
                        s.chr_ill_13_a = "Heart disease";
                    }
                    if (s.chr_ill_13.Contains("b"))
                    {
                        s.chr_ill_13_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_13.Contains("c"))
                    {
                        s.chr_ill_13_c = "Kidneys problem";
                    }
                    if (s.chr_ill_13.Contains("d"))
                    {
                        s.chr_ill_13_d = "Epilepsy";
                    }
                    if (s.chr_ill_13.Contains("e"))
                    {
                        s.chr_ill_13_e = "Diabetes";
                    }
                    if (s.chr_ill_13.Contains("f"))
                    {
                        s.chr_ill_13_f = "Arthritis";
                    }
                    if (s.chr_ill_13.Contains("g"))
                    {
                        s.chr_ill_13_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_13.Contains("h"))
                    {
                        s.chr_ill_13_h = "Cancer";
                    }
                    if (s.chr_ill_13.Contains("i"))
                    {
                        s.chr_ill_13_i = "Blooed pressure";
                    }
                    if (s.chr_ill_13.Contains("j"))
                    {
                        s.chr_ill_13_j = "Gyne problem";
                    }
                    if (s.chr_ill_13.Contains("k"))
                    {
                        s.chr_ill_13_h = "Others";
                    }

                    switch (s.MUAC_13)
                    {
                        case "a":
                            s.MUAC_13 = "Red";
                            break;
                        case "b":
                            s.MUAC_13 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_13 = "Green";
                            break;
                        case "d":
                            s.MUAC_13 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_13 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_14)
                    {
                        case "a":
                            s.HL3_14 = "Head";
                            break;
                        case "b":
                            s.HL3_14 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_14 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_14 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_14 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_14 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_14 = "Parent";
                            break;
                        case "h":
                            s.HL3_14 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_14 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_14 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_14 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_14 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_14 = "Other relative";
                            break;
                        case "n":
                            s.HL3_14 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_14 = "Not related";
                            break;
                        case "p":
                            s.HL3_14 = "Dont know";
                            break;
                    }

                    switch (s.HL4_14)
                    {
                        case "a":
                            s.HL4_14 = "Male";
                            break;
                        case "b":
                            s.HL4_14 = "Female";
                            break;
                    }


                    if (s.HL7_14.Contains("a"))
                    {
                        s.HL7_14_a = "None";
                    }
                    if (s.HL7_14.Contains("b"))
                    {
                        s.HL7_14_b = "Seperated Child";
                    }
                    if (s.HL7_14.Contains("c"))
                    {
                        s.HL7_14_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_14.Contains("d"))
                    {
                        s.HL7_14_d = "Physically disabled";
                    }
                    if (s.HL7_14.Contains("e"))
                    {
                        s.HL7_14_e = "Mentally Disabled";
                    }
                    if (s.HL7_14.Contains("f"))
                    {
                        s.HL7_14_f = "Chronically ill";
                    }
                    if (s.HL7_14.Contains("g"))
                    {
                        s.HL7_14_g = "Widow";
                    }
                    if (s.HL7_14.Contains("h"))
                    {
                        s.HL7_14_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_14.Contains("a"))
                    {
                        s.phy_disable_14_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_14.Contains("b"))
                    {
                        s.phy_disable_14_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_14.Contains("c"))
                    {
                        s.phy_disable_14_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_14.Contains("d"))
                    {
                        s.phy_disable_14_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_14.Contains("e"))
                    {
                        s.phy_disable_14_e = "Polio";
                    }
                    if (s.phy_disable_14.Contains("f"))
                    {
                        s.phy_disable_14_f = "Loss of body parts";
                    }
                    if (s.phy_disable_14.Contains("g"))
                    {
                        s.phy_disable_14_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_14.Contains("h"))
                    {
                        s.phy_disable_14_h = "Paralyses";
                    }
                    if (s.phy_disable_14.Contains("i"))
                    {
                        s.phy_disable_14_i = "Dumb";
                    }
                    if (s.phy_disable_14.Contains("j"))
                    {
                        s.phy_disable_14_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_14.Contains("a"))
                    {
                        s.chr_ill_14_a = "Heart disease";
                    }
                    if (s.chr_ill_14.Contains("b"))
                    {
                        s.chr_ill_14_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_14.Contains("c"))
                    {
                        s.chr_ill_14_c = "Kidneys problem";
                    }
                    if (s.chr_ill_14.Contains("d"))
                    {
                        s.chr_ill_14_d = "Epilepsy";
                    }
                    if (s.chr_ill_14.Contains("e"))
                    {
                        s.chr_ill_14_e = "Diabetes";
                    }
                    if (s.chr_ill_14.Contains("f"))
                    {
                        s.chr_ill_14_f = "Arthritis";
                    }
                    if (s.chr_ill_14.Contains("g"))
                    {
                        s.chr_ill_14_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_14.Contains("h"))
                    {
                        s.chr_ill_14_h = "Cancer";
                    }
                    if (s.chr_ill_14.Contains("i"))
                    {
                        s.chr_ill_14_i = "Blooed pressure";
                    }
                    if (s.chr_ill_14.Contains("j"))
                    {
                        s.chr_ill_14_j = "Gyne problem";
                    }
                    if (s.chr_ill_14.Contains("k"))
                    {
                        s.chr_ill_14_h = "Others";
                    }

                    switch (s.MUAC_14)
                    {
                        case "a":
                            s.MUAC_14 = "Red";
                            break;
                        case "b":
                            s.MUAC_14 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_14 = "Green";
                            break;
                        case "d":
                            s.MUAC_14 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_14 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_15)
                    {
                        case "a":
                            s.HL3_15 = "Head";
                            break;
                        case "b":
                            s.HL3_15 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_15 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_15 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_15 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_15 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_15 = "Parent";
                            break;
                        case "h":
                            s.HL3_15 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_15 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_15 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_15 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_15 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_15 = "Other relative";
                            break;
                        case "n":
                            s.HL3_15 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_15 = "Not related";
                            break;
                        case "p":
                            s.HL3_15 = "Dont know";
                            break;
                    }

                    switch (s.HL4_15)
                    {
                        case "a":
                            s.HL4_15 = "Male";
                            break;
                        case "b":
                            s.HL4_15 = "Female";
                            break;
                    }


                    if (s.HL7_15.Contains("a"))
                    {
                        s.HL7_15_a = "None";
                    }
                    if (s.HL7_15.Contains("b"))
                    {
                        s.HL7_15_b = "Seperated Child";
                    }
                    if (s.HL7_15.Contains("c"))
                    {
                        s.HL7_15_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_15.Contains("d"))
                    {
                        s.HL7_15_d = "Physically disabled";
                    }
                    if (s.HL7_15.Contains("e"))
                    {
                        s.HL7_15_e = "Mentally Disabled";
                    }
                    if (s.HL7_15.Contains("f"))
                    {
                        s.HL7_15_f = "Chronically ill";
                    }
                    if (s.HL7_15.Contains("g"))
                    {
                        s.HL7_15_g = "Widow";
                    }
                    if (s.HL7_15.Contains("h"))
                    {
                        s.HL7_15_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_15.Contains("a"))
                    {
                        s.phy_disable_15_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_15.Contains("b"))
                    {
                        s.phy_disable_15_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_15.Contains("c"))
                    {
                        s.phy_disable_15_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_15.Contains("d"))
                    {
                        s.phy_disable_15_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_15.Contains("e"))
                    {
                        s.phy_disable_15_e = "Polio";
                    }
                    if (s.phy_disable_15.Contains("f"))
                    {
                        s.phy_disable_15_f = "Loss of body parts";
                    }
                    if (s.phy_disable_15.Contains("g"))
                    {
                        s.phy_disable_15_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_15.Contains("h"))
                    {
                        s.phy_disable_15_h = "Paralyses";
                    }
                    if (s.phy_disable_15.Contains("i"))
                    {
                        s.phy_disable_15_i = "Dumb";
                    }
                    if (s.phy_disable_15.Contains("j"))
                    {
                        s.phy_disable_15_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_15.Contains("a"))
                    {
                        s.chr_ill_15_a = "Heart disease";
                    }
                    if (s.chr_ill_15.Contains("b"))
                    {
                        s.chr_ill_15_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_15.Contains("c"))
                    {
                        s.chr_ill_15_c = "Kidneys problem";
                    }
                    if (s.chr_ill_15.Contains("d"))
                    {
                        s.chr_ill_15_d = "Epilepsy";
                    }
                    if (s.chr_ill_15.Contains("e"))
                    {
                        s.chr_ill_15_e = "Diabetes";
                    }
                    if (s.chr_ill_15.Contains("f"))
                    {
                        s.chr_ill_15_f = "Arthritis";
                    }
                    if (s.chr_ill_15.Contains("g"))
                    {
                        s.chr_ill_15_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_15.Contains("h"))
                    {
                        s.chr_ill_15_h = "Cancer";
                    }
                    if (s.chr_ill_15.Contains("i"))
                    {
                        s.chr_ill_15_i = "Blooed pressure";
                    }
                    if (s.chr_ill_15.Contains("j"))
                    {
                        s.chr_ill_15_j = "Gyne problem";
                    }
                    if (s.chr_ill_15.Contains("k"))
                    {
                        s.chr_ill_15_h = "Others";
                    }

                    switch (s.MUAC_15)
                    {
                        case "a":
                            s.MUAC_15 = "Red";
                            break;
                        case "b":
                            s.MUAC_15 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_15 = "Green";
                            break;
                        case "d":
                            s.MUAC_15 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_15 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_16)
                    {
                        case "a":
                            s.HL3_16 = "Head";
                            break;
                        case "b":
                            s.HL3_16 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_16 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_16 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_16 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_16 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_16 = "Parent";
                            break;
                        case "h":
                            s.HL3_16 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_16 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_16 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_16 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_16 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_16 = "Other relative";
                            break;
                        case "n":
                            s.HL3_16 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_16 = "Not related";
                            break;
                        case "p":
                            s.HL3_16 = "Dont know";
                            break;
                    }

                    switch (s.HL4_16)
                    {
                        case "a":
                            s.HL4_16 = "Male";
                            break;
                        case "b":
                            s.HL4_16 = "Female";
                            break;
                    }


                    if (s.HL7_16.Contains("a"))
                    {
                        s.HL7_16_a = "None";
                    }
                    if (s.HL7_16.Contains("b"))
                    {
                        s.HL7_16_b = "Seperated Child";
                    }
                    if (s.HL7_16.Contains("c"))
                    {
                        s.HL7_16_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_16.Contains("d"))
                    {
                        s.HL7_16_d = "Physically disabled";
                    }
                    if (s.HL7_16.Contains("e"))
                    {
                        s.HL7_16_e = "Mentally Disabled";
                    }
                    if (s.HL7_16.Contains("f"))
                    {
                        s.HL7_16_f = "Chronically ill";
                    }
                    if (s.HL7_16.Contains("g"))
                    {
                        s.HL7_16_g = "Widow";
                    }
                    if (s.HL7_16.Contains("h"))
                    {
                        s.HL7_16_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_16.Contains("a"))
                    {
                        s.phy_disable_16_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_16.Contains("b"))
                    {
                        s.phy_disable_16_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_16.Contains("c"))
                    {
                        s.phy_disable_16_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_16.Contains("d"))
                    {
                        s.phy_disable_16_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_16.Contains("e"))
                    {
                        s.phy_disable_16_e = "Polio";
                    }
                    if (s.phy_disable_16.Contains("f"))
                    {
                        s.phy_disable_16_f = "Loss of body parts";
                    }
                    if (s.phy_disable_16.Contains("g"))
                    {
                        s.phy_disable_16_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_16.Contains("h"))
                    {
                        s.phy_disable_16_h = "Paralyses";
                    }
                    if (s.phy_disable_16.Contains("i"))
                    {
                        s.phy_disable_16_i = "Dumb";
                    }
                    if (s.phy_disable_16.Contains("j"))
                    {
                        s.phy_disable_16_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_16.Contains("a"))
                    {
                        s.chr_ill_16_a = "Heart disease";
                    }
                    if (s.chr_ill_16.Contains("b"))
                    {
                        s.chr_ill_16_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_16.Contains("c"))
                    {
                        s.chr_ill_16_c = "Kidneys problem";
                    }
                    if (s.chr_ill_16.Contains("d"))
                    {
                        s.chr_ill_16_d = "Epilepsy";
                    }
                    if (s.chr_ill_16.Contains("e"))
                    {
                        s.chr_ill_16_e = "Diabetes";
                    }
                    if (s.chr_ill_16.Contains("f"))
                    {
                        s.chr_ill_16_f = "Arthritis";
                    }
                    if (s.chr_ill_16.Contains("g"))
                    {
                        s.chr_ill_16_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_16.Contains("h"))
                    {
                        s.chr_ill_16_h = "Cancer";
                    }
                    if (s.chr_ill_16.Contains("i"))
                    {
                        s.chr_ill_16_i = "Blooed pressure";
                    }
                    if (s.chr_ill_16.Contains("j"))
                    {
                        s.chr_ill_16_j = "Gyne problem";
                    }
                    if (s.chr_ill_16.Contains("k"))
                    {
                        s.chr_ill_16_h = "Others";
                    }

                    switch (s.MUAC_16)
                    {
                        case "a":
                            s.MUAC_16 = "Red";
                            break;
                        case "b":
                            s.MUAC_16 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_16 = "Green";
                            break;
                        case "d":
                            s.MUAC_16 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_16 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_17)
                    {
                        case "a":
                            s.HL3_17 = "Head";
                            break;
                        case "b":
                            s.HL3_17 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_17 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_17 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_17 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_17 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_17 = "Parent";
                            break;
                        case "h":
                            s.HL3_17 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_17 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_17 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_17 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_17 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_17 = "Other relative";
                            break;
                        case "n":
                            s.HL3_17 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_17 = "Not related";
                            break;
                        case "p":
                            s.HL3_17 = "Dont know";
                            break;
                    }

                    switch (s.HL4_17)
                    {
                        case "a":
                            s.HL4_17 = "Male";
                            break;
                        case "b":
                            s.HL4_17 = "Female";
                            break;
                    }


                    if (s.HL7_17.Contains("a"))
                    {
                        s.HL7_17_a = "None";
                    }
                    if (s.HL7_17.Contains("b"))
                    {
                        s.HL7_17_b = "Seperated Child";
                    }
                    if (s.HL7_17.Contains("c"))
                    {
                        s.HL7_17_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_17.Contains("d"))
                    {
                        s.HL7_17_d = "Physically disabled";
                    }
                    if (s.HL7_17.Contains("e"))
                    {
                        s.HL7_17_e = "Mentally Disabled";
                    }
                    if (s.HL7_17.Contains("f"))
                    {
                        s.HL7_17_f = "Chronically ill";
                    }
                    if (s.HL7_17.Contains("g"))
                    {
                        s.HL7_17_g = "Widow";
                    }
                    if (s.HL7_17.Contains("h"))
                    {
                        s.HL7_17_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_17.Contains("a"))
                    {
                        s.phy_disable_17_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_17.Contains("b"))
                    {
                        s.phy_disable_17_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_17.Contains("c"))
                    {
                        s.phy_disable_17_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_17.Contains("d"))
                    {
                        s.phy_disable_17_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_17.Contains("e"))
                    {
                        s.phy_disable_17_e = "Polio";
                    }
                    if (s.phy_disable_17.Contains("f"))
                    {
                        s.phy_disable_17_f = "Loss of body parts";
                    }
                    if (s.phy_disable_17.Contains("g"))
                    {
                        s.phy_disable_17_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_17.Contains("h"))
                    {
                        s.phy_disable_17_h = "Paralyses";
                    }
                    if (s.phy_disable_17.Contains("i"))
                    {
                        s.phy_disable_17_i = "Dumb";
                    }
                    if (s.phy_disable_17.Contains("j"))
                    {
                        s.phy_disable_17_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_17.Contains("a"))
                    {
                        s.chr_ill_17_a = "Heart disease";
                    }
                    if (s.chr_ill_17.Contains("b"))
                    {
                        s.chr_ill_17_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_17.Contains("c"))
                    {
                        s.chr_ill_17_c = "Kidneys problem";
                    }
                    if (s.chr_ill_17.Contains("d"))
                    {
                        s.chr_ill_17_d = "Epilepsy";
                    }
                    if (s.chr_ill_17.Contains("e"))
                    {
                        s.chr_ill_17_e = "Diabetes";
                    }
                    if (s.chr_ill_17.Contains("f"))
                    {
                        s.chr_ill_17_f = "Arthritis";
                    }
                    if (s.chr_ill_17.Contains("g"))
                    {
                        s.chr_ill_17_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_17.Contains("h"))
                    {
                        s.chr_ill_17_h = "Cancer";
                    }
                    if (s.chr_ill_17.Contains("i"))
                    {
                        s.chr_ill_17_i = "Blooed pressure";
                    }
                    if (s.chr_ill_17.Contains("j"))
                    {
                        s.chr_ill_17_j = "Gyne problem";
                    }
                    if (s.chr_ill_17.Contains("k"))
                    {
                        s.chr_ill_17_h = "Others";
                    }

                    switch (s.MUAC_17)
                    {
                        case "a":
                            s.MUAC_17 = "Red";
                            break;
                        case "b":
                            s.MUAC_17 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_17 = "Green";
                            break;
                        case "d":
                            s.MUAC_17 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_17 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_18)
                    {
                        case "a":
                            s.HL3_18 = "Head";
                            break;
                        case "b":
                            s.HL3_18 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_18 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_18 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_18 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_18 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_18 = "Parent";
                            break;
                        case "h":
                            s.HL3_18 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_18 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_18 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_18 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_18 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_18 = "Other relative";
                            break;
                        case "n":
                            s.HL3_18 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_18 = "Not related";
                            break;
                        case "p":
                            s.HL3_18 = "Dont know";
                            break;
                    }

                    switch (s.HL4_18)
                    {
                        case "a":
                            s.HL4_18 = "Male";
                            break;
                        case "b":
                            s.HL4_18 = "Female";
                            break;
                    }


                    if (s.HL7_18.Contains("a"))
                    {
                        s.HL7_18_a = "None";
                    }
                    if (s.HL7_18.Contains("b"))
                    {
                        s.HL7_18_b = "Seperated Child";
                    }
                    if (s.HL7_18.Contains("c"))
                    {
                        s.HL7_18_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_18.Contains("d"))
                    {
                        s.HL7_18_d = "Physically disabled";
                    }
                    if (s.HL7_18.Contains("e"))
                    {
                        s.HL7_18_e = "Mentally Disabled";
                    }
                    if (s.HL7_18.Contains("f"))
                    {
                        s.HL7_18_f = "Chronically ill";
                    }
                    if (s.HL7_18.Contains("g"))
                    {
                        s.HL7_18_g = "Widow";
                    }
                    if (s.HL7_18.Contains("h"))
                    {
                        s.HL7_18_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_18.Contains("a"))
                    {
                        s.phy_disable_18_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_18.Contains("b"))
                    {
                        s.phy_disable_18_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_18.Contains("c"))
                    {
                        s.phy_disable_18_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_18.Contains("d"))
                    {
                        s.phy_disable_18_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_18.Contains("e"))
                    {
                        s.phy_disable_18_e = "Polio";
                    }
                    if (s.phy_disable_18.Contains("f"))
                    {
                        s.phy_disable_18_f = "Loss of body parts";
                    }
                    if (s.phy_disable_18.Contains("g"))
                    {
                        s.phy_disable_18_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_18.Contains("h"))
                    {
                        s.phy_disable_18_h = "Paralyses";
                    }
                    if (s.phy_disable_18.Contains("i"))
                    {
                        s.phy_disable_18_i = "Dumb";
                    }
                    if (s.phy_disable_18.Contains("j"))
                    {
                        s.phy_disable_18_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_18.Contains("a"))
                    {
                        s.chr_ill_18_a = "Heart disease";
                    }
                    if (s.chr_ill_18.Contains("b"))
                    {
                        s.chr_ill_18_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_18.Contains("c"))
                    {
                        s.chr_ill_18_c = "Kidneys problem";
                    }
                    if (s.chr_ill_18.Contains("d"))
                    {
                        s.chr_ill_18_d = "Epilepsy";
                    }
                    if (s.chr_ill_18.Contains("e"))
                    {
                        s.chr_ill_18_e = "Diabetes";
                    }
                    if (s.chr_ill_18.Contains("f"))
                    {
                        s.chr_ill_18_f = "Arthritis";
                    }
                    if (s.chr_ill_18.Contains("g"))
                    {
                        s.chr_ill_18_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_18.Contains("h"))
                    {
                        s.chr_ill_18_h = "Cancer";
                    }
                    if (s.chr_ill_18.Contains("i"))
                    {
                        s.chr_ill_18_i = "Blooed pressure";
                    }
                    if (s.chr_ill_18.Contains("j"))
                    {
                        s.chr_ill_18_j = "Gyne problem";
                    }
                    if (s.chr_ill_18.Contains("k"))
                    {
                        s.chr_ill_18_h = "Others";
                    }

                    switch (s.MUAC_18)
                    {
                        case "a":
                            s.MUAC_18 = "Red";
                            break;
                        case "b":
                            s.MUAC_18 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_18 = "Green";
                            break;
                        case "d":
                            s.MUAC_18 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_18 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_19)
                    {
                        case "a":
                            s.HL3_19 = "Head";
                            break;
                        case "b":
                            s.HL3_19 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_19 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_19 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_19 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_19 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_19 = "Parent";
                            break;
                        case "h":
                            s.HL3_19 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_19 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_19 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_19 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_19 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_19 = "Other relative";
                            break;
                        case "n":
                            s.HL3_19 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_19 = "Not related";
                            break;
                        case "p":
                            s.HL3_19 = "Dont know";
                            break;
                    }

                    switch (s.HL4_19)
                    {
                        case "a":
                            s.HL4_19 = "Male";
                            break;
                        case "b":
                            s.HL4_19 = "Female";
                            break;
                    }


                    if (s.HL7_19.Contains("a"))
                    {
                        s.HL7_19_a = "None";
                    }
                    if (s.HL7_19.Contains("b"))
                    {
                        s.HL7_19_b = "Seperated Child";
                    }
                    if (s.HL7_19.Contains("c"))
                    {
                        s.HL7_19_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_19.Contains("d"))
                    {
                        s.HL7_19_d = "Physically disabled";
                    }
                    if (s.HL7_19.Contains("e"))
                    {
                        s.HL7_19_e = "Mentally Disabled";
                    }
                    if (s.HL7_19.Contains("f"))
                    {
                        s.HL7_19_f = "Chronically ill";
                    }
                    if (s.HL7_19.Contains("g"))
                    {
                        s.HL7_19_g = "Widow";
                    }
                    if (s.HL7_19.Contains("h"))
                    {
                        s.HL7_19_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_19.Contains("a"))
                    {
                        s.phy_disable_19_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_19.Contains("b"))
                    {
                        s.phy_disable_19_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_19.Contains("c"))
                    {
                        s.phy_disable_19_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_19.Contains("d"))
                    {
                        s.phy_disable_19_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_19.Contains("e"))
                    {
                        s.phy_disable_19_e = "Polio";
                    }
                    if (s.phy_disable_19.Contains("f"))
                    {
                        s.phy_disable_19_f = "Loss of body parts";
                    }
                    if (s.phy_disable_19.Contains("g"))
                    {
                        s.phy_disable_19_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_19.Contains("h"))
                    {
                        s.phy_disable_19_h = "Paralyses";
                    }
                    if (s.phy_disable_19.Contains("i"))
                    {
                        s.phy_disable_19_i = "Dumb";
                    }
                    if (s.phy_disable_19.Contains("j"))
                    {
                        s.phy_disable_19_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_19.Contains("a"))
                    {
                        s.chr_ill_19_a = "Heart disease";
                    }
                    if (s.chr_ill_19.Contains("b"))
                    {
                        s.chr_ill_19_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_19.Contains("c"))
                    {
                        s.chr_ill_19_c = "Kidneys problem";
                    }
                    if (s.chr_ill_19.Contains("d"))
                    {
                        s.chr_ill_19_d = "Epilepsy";
                    }
                    if (s.chr_ill_19.Contains("e"))
                    {
                        s.chr_ill_19_e = "Diabetes";
                    }
                    if (s.chr_ill_19.Contains("f"))
                    {
                        s.chr_ill_19_f = "Arthritis";
                    }
                    if (s.chr_ill_19.Contains("g"))
                    {
                        s.chr_ill_19_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_19.Contains("h"))
                    {
                        s.chr_ill_19_h = "Cancer";
                    }
                    if (s.chr_ill_19.Contains("i"))
                    {
                        s.chr_ill_19_i = "Blooed pressure";
                    }
                    if (s.chr_ill_19.Contains("j"))
                    {
                        s.chr_ill_19_j = "Gyne problem";
                    }
                    if (s.chr_ill_19.Contains("k"))
                    {
                        s.chr_ill_19_h = "Others";
                    }

                    switch (s.MUAC_19)
                    {
                        case "a":
                            s.MUAC_19 = "Red";
                            break;
                        case "b":
                            s.MUAC_19 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_19 = "Green";
                            break;
                        case "d":
                            s.MUAC_19 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_19 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_20)
                    {
                        case "a":
                            s.HL3_20 = "Head";
                            break;
                        case "b":
                            s.HL3_20 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_20 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_20 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_20 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_20 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_20 = "Parent";
                            break;
                        case "h":
                            s.HL3_20 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_20 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_20 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_20 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_20 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_20 = "Other relative";
                            break;
                        case "n":
                            s.HL3_20 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_20 = "Not related";
                            break;
                        case "p":
                            s.HL3_20 = "Dont know";
                            break;
                    }

                    switch (s.HL4_20)
                    {
                        case "a":
                            s.HL4_20 = "Male";
                            break;
                        case "b":
                            s.HL4_20 = "Female";
                            break;
                    }


                    if (s.HL7_20.Contains("a"))
                    {
                        s.HL7_20_a = "None";
                    }
                    if (s.HL7_20.Contains("b"))
                    {
                        s.HL7_20_b = "Seperated Child";
                    }
                    if (s.HL7_20.Contains("c"))
                    {
                        s.HL7_20_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_20.Contains("d"))
                    {
                        s.HL7_20_d = "Physically disabled";
                    }
                    if (s.HL7_20.Contains("e"))
                    {
                        s.HL7_20_e = "Mentally Disabled";
                    }
                    if (s.HL7_20.Contains("f"))
                    {
                        s.HL7_20_f = "Chronically ill";
                    }
                    if (s.HL7_20.Contains("g"))
                    {
                        s.HL7_20_g = "Widow";
                    }
                    if (s.HL7_20.Contains("h"))
                    {
                        s.HL7_20_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_20.Contains("a"))
                    {
                        s.phy_disable_20_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_20.Contains("b"))
                    {
                        s.phy_disable_20_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_20.Contains("c"))
                    {
                        s.phy_disable_20_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_20.Contains("d"))
                    {
                        s.phy_disable_20_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_20.Contains("e"))
                    {
                        s.phy_disable_20_e = "Polio";
                    }
                    if (s.phy_disable_20.Contains("f"))
                    {
                        s.phy_disable_20_f = "Loss of body parts";
                    }
                    if (s.phy_disable_20.Contains("g"))
                    {
                        s.phy_disable_20_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_20.Contains("h"))
                    {
                        s.phy_disable_20_h = "Paralyses";
                    }
                    if (s.phy_disable_20.Contains("i"))
                    {
                        s.phy_disable_20_i = "Dumb";
                    }
                    if (s.phy_disable_20.Contains("j"))
                    {
                        s.phy_disable_20_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_20.Contains("a"))
                    {
                        s.chr_ill_20_a = "Heart disease";
                    }
                    if (s.chr_ill_20.Contains("b"))
                    {
                        s.chr_ill_20_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_20.Contains("c"))
                    {
                        s.chr_ill_20_c = "Kidneys problem";
                    }
                    if (s.chr_ill_20.Contains("d"))
                    {
                        s.chr_ill_20_d = "Epilepsy";
                    }
                    if (s.chr_ill_20.Contains("e"))
                    {
                        s.chr_ill_20_e = "Diabetes";
                    }
                    if (s.chr_ill_20.Contains("f"))
                    {
                        s.chr_ill_20_f = "Arthritis";
                    }
                    if (s.chr_ill_20.Contains("g"))
                    {
                        s.chr_ill_20_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_20.Contains("h"))
                    {
                        s.chr_ill_20_h = "Cancer";
                    }
                    if (s.chr_ill_20.Contains("i"))
                    {
                        s.chr_ill_20_i = "Blooed pressure";
                    }
                    if (s.chr_ill_20.Contains("j"))
                    {
                        s.chr_ill_20_j = "Gyne problem";
                    }
                    if (s.chr_ill_20.Contains("k"))
                    {
                        s.chr_ill_20_h = "Others";
                    }

                    switch (s.MUAC_20)
                    {
                        case "a":
                            s.MUAC_20 = "Red";
                            break;
                        case "b":
                            s.MUAC_20 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_20 = "Green";
                            break;
                        case "d":
                            s.MUAC_20 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_20 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_21)
                    {
                        case "a":
                            s.HL3_21 = "Head";
                            break;
                        case "b":
                            s.HL3_21 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_21 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_21 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_21 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_21 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_21 = "Parent";
                            break;
                        case "h":
                            s.HL3_21 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_21 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_21 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_21 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_21 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_21 = "Other relative";
                            break;
                        case "n":
                            s.HL3_21 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_21 = "Not related";
                            break;
                        case "p":
                            s.HL3_21 = "Dont know";
                            break;
                    }

                    switch (s.HL4_21)
                    {
                        case "a":
                            s.HL4_21 = "Male";
                            break;
                        case "b":
                            s.HL4_21 = "Female";
                            break;
                    }


                    if (s.HL7_21.Contains("a"))
                    {
                        s.HL7_21_a = "None";
                    }
                    if (s.HL7_21.Contains("b"))
                    {
                        s.HL7_21_b = "Seperated Child";
                    }
                    if (s.HL7_21.Contains("c"))
                    {
                        s.HL7_21_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_21.Contains("d"))
                    {
                        s.HL7_21_d = "Physically disabled";
                    }
                    if (s.HL7_21.Contains("e"))
                    {
                        s.HL7_21_e = "Mentally Disabled";
                    }
                    if (s.HL7_21.Contains("f"))
                    {
                        s.HL7_21_f = "Chronically ill";
                    }
                    if (s.HL7_21.Contains("g"))
                    {
                        s.HL7_21_g = "Widow";
                    }
                    if (s.HL7_21.Contains("h"))
                    {
                        s.HL7_21_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_21.Contains("a"))
                    {
                        s.phy_disable_21_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_21.Contains("b"))
                    {
                        s.phy_disable_21_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_21.Contains("c"))
                    {
                        s.phy_disable_21_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_21.Contains("d"))
                    {
                        s.phy_disable_21_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_21.Contains("e"))
                    {
                        s.phy_disable_21_e = "Polio";
                    }
                    if (s.phy_disable_21.Contains("f"))
                    {
                        s.phy_disable_21_f = "Loss of body parts";
                    }
                    if (s.phy_disable_21.Contains("g"))
                    {
                        s.phy_disable_21_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_21.Contains("h"))
                    {
                        s.phy_disable_21_h = "Paralyses";
                    }
                    if (s.phy_disable_21.Contains("i"))
                    {
                        s.phy_disable_21_i = "Dumb";
                    }
                    if (s.phy_disable_21.Contains("j"))
                    {
                        s.phy_disable_21_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_21.Contains("a"))
                    {
                        s.chr_ill_21_a = "Heart disease";
                    }
                    if (s.chr_ill_21.Contains("b"))
                    {
                        s.chr_ill_21_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_21.Contains("c"))
                    {
                        s.chr_ill_21_c = "Kidneys problem";
                    }
                    if (s.chr_ill_21.Contains("d"))
                    {
                        s.chr_ill_21_d = "Epilepsy";
                    }
                    if (s.chr_ill_21.Contains("e"))
                    {
                        s.chr_ill_21_e = "Diabetes";
                    }
                    if (s.chr_ill_21.Contains("f"))
                    {
                        s.chr_ill_21_f = "Arthritis";
                    }
                    if (s.chr_ill_21.Contains("g"))
                    {
                        s.chr_ill_21_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_21.Contains("h"))
                    {
                        s.chr_ill_21_h = "Cancer";
                    }
                    if (s.chr_ill_21.Contains("i"))
                    {
                        s.chr_ill_21_i = "Blooed pressure";
                    }
                    if (s.chr_ill_21.Contains("j"))
                    {
                        s.chr_ill_21_j = "Gyne problem";
                    }
                    if (s.chr_ill_21.Contains("k"))
                    {
                        s.chr_ill_21_h = "Others";
                    }

                    switch (s.MUAC_21)
                    {
                        case "a":
                            s.MUAC_21 = "Red";
                            break;
                        case "b":
                            s.MUAC_21 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_21 = "Green";
                            break;
                        case "d":
                            s.MUAC_21 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_21 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_22)
                    {
                        case "a":
                            s.HL3_22 = "Head";
                            break;
                        case "b":
                            s.HL3_22 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_22 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_22 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_22 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_22 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_22 = "Parent";
                            break;
                        case "h":
                            s.HL3_22 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_22 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_22 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_22 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_22 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_22 = "Other relative";
                            break;
                        case "n":
                            s.HL3_22 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_22 = "Not related";
                            break;
                        case "p":
                            s.HL3_22 = "Dont know";
                            break;
                    }

                    switch (s.HL4_22)
                    {
                        case "a":
                            s.HL4_22 = "Male";
                            break;
                        case "b":
                            s.HL4_22 = "Female";
                            break;
                    }


                    if (s.HL7_22.Contains("a"))
                    {
                        s.HL7_22_a = "None";
                    }
                    if (s.HL7_22.Contains("b"))
                    {
                        s.HL7_22_b = "Seperated Child";
                    }
                    if (s.HL7_22.Contains("c"))
                    {
                        s.HL7_22_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_22.Contains("d"))
                    {
                        s.HL7_22_d = "Physically disabled";
                    }
                    if (s.HL7_22.Contains("e"))
                    {
                        s.HL7_22_e = "Mentally Disabled";
                    }
                    if (s.HL7_22.Contains("f"))
                    {
                        s.HL7_22_f = "Chronically ill";
                    }
                    if (s.HL7_22.Contains("g"))
                    {
                        s.HL7_22_g = "Widow";
                    }
                    if (s.HL7_22.Contains("h"))
                    {
                        s.HL7_22_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_22.Contains("a"))
                    {
                        s.phy_disable_22_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_22.Contains("b"))
                    {
                        s.phy_disable_22_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_22.Contains("c"))
                    {
                        s.phy_disable_22_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_22.Contains("d"))
                    {
                        s.phy_disable_22_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_22.Contains("e"))
                    {
                        s.phy_disable_22_e = "Polio";
                    }
                    if (s.phy_disable_22.Contains("f"))
                    {
                        s.phy_disable_22_f = "Loss of body parts";
                    }
                    if (s.phy_disable_22.Contains("g"))
                    {
                        s.phy_disable_22_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_22.Contains("h"))
                    {
                        s.phy_disable_22_h = "Paralyses";
                    }
                    if (s.phy_disable_22.Contains("i"))
                    {
                        s.phy_disable_22_i = "Dumb";
                    }
                    if (s.phy_disable_22.Contains("j"))
                    {
                        s.phy_disable_22_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_22.Contains("a"))
                    {
                        s.chr_ill_22_a = "Heart disease";
                    }
                    if (s.chr_ill_22.Contains("b"))
                    {
                        s.chr_ill_22_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_22.Contains("c"))
                    {
                        s.chr_ill_22_c = "Kidneys problem";
                    }
                    if (s.chr_ill_22.Contains("d"))
                    {
                        s.chr_ill_22_d = "Epilepsy";
                    }
                    if (s.chr_ill_22.Contains("e"))
                    {
                        s.chr_ill_22_e = "Diabetes";
                    }
                    if (s.chr_ill_22.Contains("f"))
                    {
                        s.chr_ill_22_f = "Arthritis";
                    }
                    if (s.chr_ill_22.Contains("g"))
                    {
                        s.chr_ill_22_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_22.Contains("h"))
                    {
                        s.chr_ill_22_h = "Cancer";
                    }
                    if (s.chr_ill_22.Contains("i"))
                    {
                        s.chr_ill_22_i = "Blooed pressure";
                    }
                    if (s.chr_ill_22.Contains("j"))
                    {
                        s.chr_ill_22_j = "Gyne problem";
                    }
                    if (s.chr_ill_22.Contains("k"))
                    {
                        s.chr_ill_22_h = "Others";
                    }

                    switch (s.MUAC_22)
                    {
                        case "a":
                            s.MUAC_22 = "Red";
                            break;
                        case "b":
                            s.MUAC_22 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_22 = "Green";
                            break;
                        case "d":
                            s.MUAC_22 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_22 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_23)
                    {
                        case "a":
                            s.HL3_23 = "Head";
                            break;
                        case "b":
                            s.HL3_23 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_23 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_23 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_23 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_23 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_23 = "Parent";
                            break;
                        case "h":
                            s.HL3_23 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_23 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_23 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_23 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_23 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_23 = "Other relative";
                            break;
                        case "n":
                            s.HL3_23 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_23 = "Not related";
                            break;
                        case "p":
                            s.HL3_23 = "Dont know";
                            break;
                    }

                    switch (s.HL4_23)
                    {
                        case "a":
                            s.HL4_23 = "Male";
                            break;
                        case "b":
                            s.HL4_23 = "Female";
                            break;
                    }


                    if (s.HL7_23.Contains("a"))
                    {
                        s.HL7_23_a = "None";
                    }
                    if (s.HL7_23.Contains("b"))
                    {
                        s.HL7_23_b = "Seperated Child";
                    }
                    if (s.HL7_23.Contains("c"))
                    {
                        s.HL7_23_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_23.Contains("d"))
                    {
                        s.HL7_23_d = "Physically disabled";
                    }
                    if (s.HL7_23.Contains("e"))
                    {
                        s.HL7_23_e = "Mentally Disabled";
                    }
                    if (s.HL7_23.Contains("f"))
                    {
                        s.HL7_23_f = "Chronically ill";
                    }
                    if (s.HL7_23.Contains("g"))
                    {
                        s.HL7_23_g = "Widow";
                    }
                    if (s.HL7_23.Contains("h"))
                    {
                        s.HL7_23_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_23.Contains("a"))
                    {
                        s.phy_disable_23_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_23.Contains("b"))
                    {
                        s.phy_disable_23_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_23.Contains("c"))
                    {
                        s.phy_disable_23_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_23.Contains("d"))
                    {
                        s.phy_disable_23_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_23.Contains("e"))
                    {
                        s.phy_disable_23_e = "Polio";
                    }
                    if (s.phy_disable_23.Contains("f"))
                    {
                        s.phy_disable_23_f = "Loss of body parts";
                    }
                    if (s.phy_disable_23.Contains("g"))
                    {
                        s.phy_disable_23_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_23.Contains("h"))
                    {
                        s.phy_disable_23_h = "Paralyses";
                    }
                    if (s.phy_disable_23.Contains("i"))
                    {
                        s.phy_disable_23_i = "Dumb";
                    }
                    if (s.phy_disable_23.Contains("j"))
                    {
                        s.phy_disable_23_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_23.Contains("a"))
                    {
                        s.chr_ill_23_a = "Heart disease";
                    }
                    if (s.chr_ill_23.Contains("b"))
                    {
                        s.chr_ill_23_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_23.Contains("c"))
                    {
                        s.chr_ill_23_c = "Kidneys problem";
                    }
                    if (s.chr_ill_23.Contains("d"))
                    {
                        s.chr_ill_23_d = "Epilepsy";
                    }
                    if (s.chr_ill_23.Contains("e"))
                    {
                        s.chr_ill_23_e = "Diabetes";
                    }
                    if (s.chr_ill_23.Contains("f"))
                    {
                        s.chr_ill_23_f = "Arthritis";
                    }
                    if (s.chr_ill_23.Contains("g"))
                    {
                        s.chr_ill_23_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_23.Contains("h"))
                    {
                        s.chr_ill_23_h = "Cancer";
                    }
                    if (s.chr_ill_23.Contains("i"))
                    {
                        s.chr_ill_23_i = "Blooed pressure";
                    }
                    if (s.chr_ill_23.Contains("j"))
                    {
                        s.chr_ill_23_j = "Gyne problem";
                    }
                    if (s.chr_ill_23.Contains("k"))
                    {
                        s.chr_ill_23_h = "Others";
                    }

                    switch (s.MUAC_23)
                    {
                        case "a":
                            s.MUAC_23 = "Red";
                            break;
                        case "b":
                            s.MUAC_23 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_23 = "Green";
                            break;
                        case "d":
                            s.MUAC_23 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_23 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_24)
                    {
                        case "a":
                            s.HL3_24 = "Head";
                            break;
                        case "b":
                            s.HL3_24 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_24 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_24 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_24 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_24 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_24 = "Parent";
                            break;
                        case "h":
                            s.HL3_24 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_24 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_24 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_24 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_24 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_24 = "Other relative";
                            break;
                        case "n":
                            s.HL3_24 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_24 = "Not related";
                            break;
                        case "p":
                            s.HL3_24 = "Dont know";
                            break;
                    }

                    switch (s.HL4_24)
                    {
                        case "a":
                            s.HL4_24 = "Male";
                            break;
                        case "b":
                            s.HL4_24 = "Female";
                            break;
                    }


                    if (s.HL7_24.Contains("a"))
                    {
                        s.HL7_24_a = "None";
                    }
                    if (s.HL7_24.Contains("b"))
                    {
                        s.HL7_24_b = "Seperated Child";
                    }
                    if (s.HL7_24.Contains("c"))
                    {
                        s.HL7_24_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_24.Contains("d"))
                    {
                        s.HL7_24_d = "Physically disabled";
                    }
                    if (s.HL7_24.Contains("e"))
                    {
                        s.HL7_24_e = "Mentally Disabled";
                    }
                    if (s.HL7_24.Contains("f"))
                    {
                        s.HL7_24_f = "Chronically ill";
                    }
                    if (s.HL7_24.Contains("g"))
                    {
                        s.HL7_24_g = "Widow";
                    }
                    if (s.HL7_24.Contains("h"))
                    {
                        s.HL7_24_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_24.Contains("a"))
                    {
                        s.phy_disable_24_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_24.Contains("b"))
                    {
                        s.phy_disable_24_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_24.Contains("c"))
                    {
                        s.phy_disable_24_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_24.Contains("d"))
                    {
                        s.phy_disable_24_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_24.Contains("e"))
                    {
                        s.phy_disable_24_e = "Polio";
                    }
                    if (s.phy_disable_24.Contains("f"))
                    {
                        s.phy_disable_24_f = "Loss of body parts";
                    }
                    if (s.phy_disable_24.Contains("g"))
                    {
                        s.phy_disable_24_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_24.Contains("h"))
                    {
                        s.phy_disable_24_h = "Paralyses";
                    }
                    if (s.phy_disable_24.Contains("i"))
                    {
                        s.phy_disable_24_i = "Dumb";
                    }
                    if (s.phy_disable_24.Contains("j"))
                    {
                        s.phy_disable_24_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_24.Contains("a"))
                    {
                        s.chr_ill_24_a = "Heart disease";
                    }
                    if (s.chr_ill_24.Contains("b"))
                    {
                        s.chr_ill_24_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_24.Contains("c"))
                    {
                        s.chr_ill_24_c = "Kidneys problem";
                    }
                    if (s.chr_ill_24.Contains("d"))
                    {
                        s.chr_ill_24_d = "Epilepsy";
                    }
                    if (s.chr_ill_24.Contains("e"))
                    {
                        s.chr_ill_24_e = "Diabetes";
                    }
                    if (s.chr_ill_24.Contains("f"))
                    {
                        s.chr_ill_24_f = "Arthritis";
                    }
                    if (s.chr_ill_24.Contains("g"))
                    {
                        s.chr_ill_24_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_24.Contains("h"))
                    {
                        s.chr_ill_24_h = "Cancer";
                    }
                    if (s.chr_ill_24.Contains("i"))
                    {
                        s.chr_ill_24_i = "Blooed pressure";
                    }
                    if (s.chr_ill_24.Contains("j"))
                    {
                        s.chr_ill_24_j = "Gyne problem";
                    }
                    if (s.chr_ill_24.Contains("k"))
                    {
                        s.chr_ill_24_h = "Others";
                    }

                    switch (s.MUAC_24)
                    {
                        case "a":
                            s.MUAC_24 = "Red";
                            break;
                        case "b":
                            s.MUAC_24 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_24 = "Green";
                            break;
                        case "d":
                            s.MUAC_24 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_24 = "Parents not allowing";
                            break;
                    }
                    #endregion

                    #region FamilyMember
                    switch (s.HL3_25)
                    {
                        case "a":
                            s.HL3_25 = "Head";
                            break;
                        case "b":
                            s.HL3_25 = "Wife/Husband";
                            break;
                        case "c":
                            s.HL3_25 = "Co-Wife";
                            break;
                        case "d":
                            s.HL3_25 = "Daughter/Son";
                            break;
                        case "e":
                            s.HL3_25 = "Daughter-in-law/ Son-in-law";
                            break;
                        case "f":
                            s.HL3_25 = "Grand Child";
                            break;
                        case "g":
                            s.HL3_25 = "Parent";
                            break;
                        case "h":
                            s.HL3_25 = "Parent-in-law";
                            break;
                        case "i":
                            s.HL3_25 = "Brother/ Sister";
                            break;
                        case "j":
                            s.HL3_25 = "Brother-in-law/ Sister-in-law";
                            break;
                        case "k":
                            s.HL3_25 = "Uncle/ Aunt";
                            break;
                        case "l":
                            s.HL3_25 = "Niece/ Nephew";
                            break;
                        case "m":
                            s.HL3_25 = "Other relative";
                            break;
                        case "n":
                            s.HL3_25 = "Adopted/ Foster/ Step Child";
                            break;
                        case "o":
                            s.HL3_25 = "Not related";
                            break;
                        case "p":
                            s.HL3_25 = "Dont know";
                            break;
                    }

                    switch (s.HL4_25)
                    {
                        case "a":
                            s.HL4_25 = "Male";
                            break;
                        case "b":
                            s.HL4_25 = "Female";
                            break;
                    }


                    if (s.HL7_25.Contains("a"))
                    {
                        s.HL7_25_a = "None";
                    }
                    if (s.HL7_25.Contains("b"))
                    {
                        s.HL7_25_b = "Seperated Child";
                    }
                    if (s.HL7_25.Contains("c"))
                    {
                        s.HL7_25_c = "Orphan / Half Orphan";
                    }
                    if (s.HL7_25.Contains("d"))
                    {
                        s.HL7_25_d = "Physically disabled";
                    }
                    if (s.HL7_25.Contains("e"))
                    {
                        s.HL7_25_e = "Mentally Disabled";
                    }
                    if (s.HL7_25.Contains("f"))
                    {
                        s.HL7_25_f = "Chronically ill";
                    }
                    if (s.HL7_25.Contains("g"))
                    {
                        s.HL7_25_g = "Widow";
                    }
                    if (s.HL7_25.Contains("h"))
                    {
                        s.HL7_25_h = "Seperate from spouse";
                    }

                    if (s.phy_disable_25.Contains("a"))
                    {
                        s.phy_disable_25_a = "Visual Disabilities (blindness, color blindness, blurred vision)";
                    }
                    if (s.phy_disable_25.Contains("b"))
                    {
                        s.phy_disable_25_b = "Hearing Disabilities (Deaf, Hard of hearing)";
                    }
                    if (s.phy_disable_25.Contains("c"))
                    {
                        s.phy_disable_25_c = "Psycho-Social  Disabilities (Anxiety Disorder, Bipolar Disorder, Depression)";
                    }
                    if (s.phy_disable_25.Contains("d"))
                    {
                        s.phy_disable_25_d = "Intellectual, developmental and learning disabilities(Attention-Deficit/ Hyperactivity Disorders, Asperger Syndrome, Autism, Down syndrome, Dyslexia)";
                    }
                    if (s.phy_disable_25.Contains("e"))
                    {
                        s.phy_disable_25_e = "Polio";
                    }
                    if (s.phy_disable_25.Contains("f"))
                    {
                        s.phy_disable_25_f = "Loss of body parts";
                    }
                    if (s.phy_disable_25.Contains("g"))
                    {
                        s.phy_disable_25_g = "Congenital disability (By Birth)";
                    }
                    if (s.phy_disable_25.Contains("h"))
                    {
                        s.phy_disable_25_h = "Paralyses";
                    }
                    if (s.phy_disable_25.Contains("i"))
                    {
                        s.phy_disable_25_i = "Dumb";
                    }
                    if (s.phy_disable_25.Contains("j"))
                    {
                        s.phy_disable_25_j = "Others";
                    }

                    //sync chr_ill_4
                    if (s.chr_ill_25.Contains("a"))
                    {
                        s.chr_ill_25_a = "Heart disease";
                    }
                    if (s.chr_ill_25.Contains("b"))
                    {
                        s.chr_ill_25_b = "Asthma (Acute Respiratory Infection)";
                    }
                    if (s.chr_ill_25.Contains("c"))
                    {
                        s.chr_ill_25_c = "Kidneys problem";
                    }
                    if (s.chr_ill_25.Contains("d"))
                    {
                        s.chr_ill_25_d = "Epilepsy";
                    }
                    if (s.chr_ill_25.Contains("e"))
                    {
                        s.chr_ill_25_e = "Diabetes";
                    }
                    if (s.chr_ill_25.Contains("f"))
                    {
                        s.chr_ill_25_f = "Arthritis";
                    }
                    if (s.chr_ill_25.Contains("g"))
                    {
                        s.chr_ill_25_g = "Hepatitis B,C";
                    }
                    if (s.chr_ill_25.Contains("h"))
                    {
                        s.chr_ill_25_h = "Cancer";
                    }
                    if (s.chr_ill_25.Contains("i"))
                    {
                        s.chr_ill_25_i = "Blooed pressure";
                    }
                    if (s.chr_ill_25.Contains("j"))
                    {
                        s.chr_ill_25_j = "Gyne problem";
                    }
                    if (s.chr_ill_25.Contains("k"))
                    {
                        s.chr_ill_25_h = "Others";
                    }

                    switch (s.MUAC_25)
                    {
                        case "a":
                            s.MUAC_25 = "Red";
                            break;
                        case "b":
                            s.MUAC_25 = "Yellow";
                            break;
                        case "c":
                            s.MUAC_25 = "Green";
                            break;
                        case "d":
                            s.MUAC_25 = "Child not available at home";
                            break;
                        case "e":
                            s.MUAC_25 = "Parents not allowing";
                            break;
                    }
                    #endregion




                    //synch P1
                    switch (s.P1)
                    {
                        case "a":
                            s.P1 = "IDP (Registered)";
                            break;
                        case "b":
                            s.P1 = "IDP (Not Registered)";
                            break;
                        case "c":
                            s.P1 = "IDP (Registered but blocked)";
                            break;
                    }

                    //sync P2
                    if (s.P2.Contains("a"))
                    {
                        s.P2_a = "Dont know about registration process (where/how)?";
                    }
                    if (s.P2.Contains("b"))
                    {
                        s.P2_b = "Not able to reach the registration site (eg. money for transport, disabled, female headed hh)";
                    }
                    if (s.P2.Contains("c"))
                    {
                        s.P2_c = "Complicated process at registration site (eg. long queues)";
                    }
                    if (s.P2.Contains("d"))
                    {
                        s.P2_d = "Lack of documentation/CNIC";
                    }
                    if (s.P2.Contains("e"))
                    {
                        s.P2_e = "Do not think it is important";
                    }
                    if (s.P2.Contains("f"))
                    {
                        s.P2_f = "I have been told NOT to register";
                    }
                    if (s.P2.Contains("g"))
                    {
                        s.P2_g = "Area of origin not notified";
                    }
                    if (s.P2.Contains("h"))
                    {
                        s.P2_h = "Problem with CNIC (eg. dual address, duplicate family number)";
                    }
                    if (s.P2.Contains("i"))
                    {
                        s.P2_i = "Other";
                    }

                    //sync P4
                    switch (s.P4)
                    {
                        case "a":
                            s.P4 = "Yes";
                            break;
                        case "b":
                            s.P4 = "No";
                            break;
                    }

                    //sync P5

                    switch (s.P5)
                    {
                        case "a":
                            s.P5 = "Immediately";
                            break;
                        case "b":
                            s.P5 = "As soon as it is safe";
                            break;
                        case "c":
                            s.P5 = "1-3 Months";
                            break;
                        case "d":
                            s.P5 = "3-6 Months";
                            break;
                        case "e":
                            s.P5 = "More than 6 months";
                            break;
                        case "f":
                            s.P5 = "Dont know";
                            break;
                    }

                    //sync P6
                    if (s.P6.Contains("a"))
                    {
                        s.P6_a = "Security situation in the area of origin";
                    }
                    if (s.P6.Contains("b"))
                    {
                        s.P6_b = "No house (damaged/destroyed)";
                    }
                    if (s.P6.Contains("c"))
                    {
                        s.P6_c = "Damage or lack of community infrastructure (Water, Electricity, Health, Education)";
                    }
                    if (s.P6.Contains("d"))
                    {
                        s.P6_d = "There are more economic opportunities here";
                    }
                    if (s.P6.Contains("e"))
                    {
                        s.P6_e = "There is not enough assistance for returnees.";
                    }
                    if (s.P6.Contains("f"))
                    {
                        s.P6_f = "Individual threat";
                    }
                    if (s.P6.Contains("g"))
                    {
                        s.P6_g = "House Occupied";
                    }
                    if (s.P6.Contains("h"))
                    {
                        s.P6_h = "Medical treatment being received here";
                    }
                    if (s.P6.Contains("i"))
                    {
                        s.P6_i = "Other";
                    }


                    //sync P9 
                    switch (s.P9)
                    {
                        case "a":
                            s.P9 = "Yes";
                            break;
                        case "b":
                            s.P9 = "No";
                            break;
                    }

                    //sync P10
                    if (s.P10.Contains("a"))
                    {
                        s.P10_a = "Protect family property";
                    }
                    if (s.P10.Contains("b"))
                    {
                        s.P10_b = "Protect family livestock";
                    }
                    if (s.P10.Contains("c"))
                    {
                        s.P10_c = "Mentally/physically unwell";
                    }
                    if (s.P10.Contains("d"))
                    {
                        s.P10_d = "Engaged in the conflict (without choice)";
                    }
                    if (s.P10.Contains("e"))
                    {
                        s.P10_e = "Cannot afford to come";
                    }
                    if (s.P10.Contains("f"))
                    {
                        s.P10_f = "Worried they will not be able to keep pardah";
                    }

                    //sync P11 
                    switch (s.P11)
                    {
                        case "a":
                            s.P11 = "Yes";
                            break;
                        case "b":
                            s.P11 = "No";
                            break;
                    }

                    if (s.P13.Contains("a"))
                        s.P13_a = "Psychological and social distress";
                    if (s.P13.Contains("b"))
                        s.P13_b = "Child in labor";
                    if (s.P13.Contains("c"))
                        s.P13_c = "Child suffering abuse";
                    if (s.P13.Contains("d"))
                        s.P13_d = "Child facing discrimination accessing services";
                    if (s.P13.Contains("e"))
                        s.P13_e = "Child in conflict with law";
                    if (s.P13.Contains("f"))
                        s.P13_f = "Seperated unaccompanied children";
                    if (s.P13.Contains("g"))
                        s.P13_g = "Child marriages";
                    if (s.P13.Contains("h"))
                        s.P13_h = "None";

                    //Sync LA1a
                    switch (s.LA1a)
                    {
                        case "a":
                            s.LA1a = "Agriculture (own farm + Livestock + poultry)";
                            break;
                        case "b":
                            s.LA1a = "Sharecropping/ tenancy";
                            break;
                        case "c":
                            s.LA1a = "Services(Govt or private employee)";
                            break;
                        case "d":
                            s.LA1a = "Shopkeeper/trader";
                            break;
                        case "e":
                            s.LA1a = "Skilled wage labor";
                            break;
                        case "f":
                            s.LA1a = "Daily/ unskilled wage labor";
                            break;
                        case "g":
                            s.LA1a = "Remittances (local and foreign)";
                            break;
                        case "h":
                            s.LA1a = "Income support/ Zakaat";
                            break;
                        case "i":
                            s.LA1a = "Humanitarian assistance";
                            break;
                        case "j":
                            s.LA1a = "Selling of assets";
                            break;
                        case "k":
                            s.LA1a = "Others";
                            break;
                        case "l":
                            s.LA1a = "None";
                            break;
                    }

                    //Sync LA1b
                    switch (s.LA1b)
                    {
                        case "a":
                            s.LA1b = "Agriculture (own farm + Livestock + poultry)";
                            break;
                        case "b":
                            s.LA1b = "Sharecropping/ tenancy";
                            break;
                        case "c":
                            s.LA1b = "Services(Govt or private employee)";
                            break;
                        case "d":
                            s.LA1b = "Shopkeeper/trader";
                            break;
                        case "e":
                            s.LA1b = "Skilled wage labor";
                            break;
                        case "f":
                            s.LA1b = "Daily/ unskilled wage labor";
                            break;
                        case "g":
                            s.LA1b = "Remittances (local and foreign)";
                            break;
                        case "h":
                            s.LA1b = "Income support/ Zakaat";
                            break;
                        case "i":
                            s.LA1b = "Humanitarian assistance";
                            break;
                        case "j":
                            s.LA1b = "Selling of assets";
                            break;
                        case "k":
                            s.LA1b = "Others";
                            break;
                        case "l":
                            s.LA1b = "None";
                            break;
                    }

                    //Sync LA1c
                    switch (s.LA1c)
                    {
                        case "a":
                            s.LA1c = "Agriculture (own farm + Livestock + poultry)";
                            break;
                        case "b":
                            s.LA1c = "Sharecropping/ tenancy";
                            break;
                        case "c":
                            s.LA1c = "Services(Govt or private employee)";
                            break;
                        case "d":
                            s.LA1c = "Shopkeeper/trader";
                            break;
                        case "e":
                            s.LA1c = "Skilled wage labor";
                            break;
                        case "f":
                            s.LA1c = "Daily/ unskilled wage labor";
                            break;
                        case "g":
                            s.LA1c = "Remittances (local and foreign)";
                            break;
                        case "h":
                            s.LA1c = "Income support/ Zakaat";
                            break;
                        case "i":
                            s.LA1c = "Humanitarian assistance";
                            break;
                        case "j":
                            s.LA1c = "Selling of assets";
                            break;
                        case "k":
                            s.LA1c = "Others";
                            break;
                        case "l":
                            s.LA1c = "None";
                            break;
                    }

                    //Sync LA2a
                    switch (s.LA2a)
                    {
                        case "a":
                            s.LA2a = "Agriculture (own farm + Livestock + poultry)";
                            break;
                        case "b":
                            s.LA2a = "Sharecropping/ tenancy";
                            break;
                        case "c":
                            s.LA2a = "Services(Govt or private employee)";
                            break;
                        case "d":
                            s.LA2a = "Shopkeeper/trader";
                            break;
                        case "e":
                            s.LA2a = "Skilled wage labor";
                            break;
                        case "f":
                            s.LA2a = "Daily/ unskilled wage labor";
                            break;
                        case "g":
                            s.LA2a = "Remittances (local and foreign)";
                            break;
                        case "h":
                            s.LA2a = "Income support/ Zakaat";
                            break;
                        case "i":
                            s.LA2a = "Humanitarian assistance";
                            break;
                        case "j":
                            s.LA2a = "Selling of assets";
                            break;
                        case "k":
                            s.LA2a = "Others";
                            break;
                        case "l":
                            s.LA2a = "None";
                            break;
                    }

                    //Sync LA2b
                    switch (s.LA2b)
                    {
                        case "a":
                            s.LA2b = "Agriculture (own farm + Livestock + poultry)";
                            break;
                        case "b":
                            s.LA2b = "Sharecropping/ tenancy";
                            break;
                        case "c":
                            s.LA2b = "Services(Govt or private employee)";
                            break;
                        case "d":
                            s.LA2b = "Shopkeeper/trader";
                            break;
                        case "e":
                            s.LA2b = "Skilled wage labor";
                            break;
                        case "f":
                            s.LA2b = "Daily/ unskilled wage labor";
                            break;
                        case "g":
                            s.LA2b = "Remittances (local and foreign)";
                            break;
                        case "h":
                            s.LA2b = "Income support/ Zakaat";
                            break;
                        case "i":
                            s.LA2b = "Humanitarian assistance";
                            break;
                        case "j":
                            s.LA2b = "Selling of assets";
                            break;
                        case "k":
                            s.LA2b = "Others";
                            break;
                        case "l":
                            s.LA2b = "None";
                            break;
                    }

                    //Sync LA2c
                    switch (s.LA2c)
                    {
                        case "a":
                            s.LA2c = "Agriculture (own farm + Livestock + poultry)";
                            break;
                        case "b":
                            s.LA2c = "Sharecropping/ tenancy";
                            break;
                        case "c":
                            s.LA2c = "Services(Govt or private employee)";
                            break;
                        case "d":
                            s.LA2c = "Shopkeeper/trader";
                            break;
                        case "e":
                            s.LA2c = "Skilled wage labor";
                            break;
                        case "f":
                            s.LA2c = "Daily/ unskilled wage labor";
                            break;
                        case "g":
                            s.LA2c = "Remittances (local and foreign)";
                            break;
                        case "h":
                            s.LA2c = "Income support/ Zakaat";
                            break;
                        case "i":
                            s.LA2c = "Humanitarian assistance";
                            break;
                        case "j":
                            s.LA2c = "Selling of assets";
                            break;
                        case "k":
                            s.LA2c = "Others";
                            break;
                        case "l":
                            s.LA2c = "None";
                            break;
                    }


                    //sync LA3_A
                    switch (s.LA3_A)
                    {
                        case "a":
                            s.LA3_A = "Yes";
                            break;
                        case "b":
                            s.LA3_A = "No";
                            break;
                    }

                    //sync LA3 
                    if (s.LA3.Contains("a"))
                        s.LA3_1 = "Feed";
                    if (s.LA3.Contains("b"))
                        s.LA3_2 = "Medication/Vaccination";
                    if (s.LA3.Contains("c"))
                        s.LA3_3 = "Shelter/Space";
                    if (s.LA3.Contains("d"))
                        s.LA3_4 = "Milking kits";
                    if (s.LA3.Contains("e"))
                        s.LA3_5 = "Re-stocking";
                    if (s.LA3.Contains("f"))
                        s.LA3_6 = "Water";
                    if (s.LA3.Contains("g"))
                        s.LA3_7 = "Seeds";
                    if (s.LA3.Contains("h"))
                        s.LA3_8 = "Fertilizer";
                    if (s.LA3.Contains("i"))
                        s.LA3_9 = "Tools";
                    if (s.LA3.Contains("j"))
                        s.LA3_10 = "Agriculture services";
                    if (s.LA3.Contains("k"))
                        s.LA3_11 = "Others";
                    if (s.LA3.Contains("l"))
                        s.LA3_12 = "None";


                    //Sync FS4_1
                    switch (s.FS4_1)
                    {
                        case "a":
                            s.FS4_1 = "Not eaten";
                            break;
                        case "b":
                            s.FS4_1 = "1 day";
                            break;
                        case "c":
                            s.FS4_1 = "2 days";
                            break;
                        case "d":
                            s.FS4_1 = "3 days";
                            break;
                        case "e":
                            s.FS4_1 = "4 days";
                            break;
                        case "f":
                            s.FS4_1 = "5 days";
                            break;
                        case "g":
                            s.FS4_1 = "6 days";
                            break;
                        case "h":
                            s.FS4_1 = "7 days";
                            break;
                    }

                    //Sync FS4_2
                    switch (s.FS4_2)
                    {
                        case "a":
                            s.FS4_2 = "Not eaten";
                            break;
                        case "b":
                            s.FS4_2 = "1 day";
                            break;
                        case "c":
                            s.FS4_2 = "2 days";
                            break;
                        case "d":
                            s.FS4_2 = "3 days";
                            break;
                        case "e":
                            s.FS4_2 = "4 days";
                            break;
                        case "f":
                            s.FS4_2 = "5 days";
                            break;
                        case "g":
                            s.FS4_2 = "6 days";
                            break;
                        case "h":
                            s.FS4_2 = "7 days";
                            break;
                    }

                    //Sync FS4_3
                    switch (s.FS4_3)
                    {
                        case "a":
                            s.FS4_3 = "Not eaten";
                            break;
                        case "b":
                            s.FS4_3 = "1 day";
                            break;
                        case "c":
                            s.FS4_3 = "2 days";
                            break;
                        case "d":
                            s.FS4_3 = "3 days";
                            break;
                        case "e":
                            s.FS4_3 = "4 days";
                            break;
                        case "f":
                            s.FS4_3 = "5 days";
                            break;
                        case "g":
                            s.FS4_3 = "6 days";
                            break;
                        case "h":
                            s.FS4_3 = "7 days";
                            break;
                    }

                    //Sync FS4_4
                    switch (s.FS4_4)
                    {
                        case "a":
                            s.FS4_4 = "Not eaten";
                            break;
                        case "b":
                            s.FS4_4 = "1 day";
                            break;
                        case "c":
                            s.FS4_4 = "2 days";
                            break;
                        case "d":
                            s.FS4_4 = "3 days";
                            break;
                        case "e":
                            s.FS4_4 = "4 days";
                            break;
                        case "f":
                            s.FS4_4 = "5 days";
                            break;
                        case "g":
                            s.FS4_4 = "6 days";
                            break;
                        case "h":
                            s.FS4_4 = "7 days";
                            break;
                    }

                    //Sync FS4_5
                    switch (s.FS4_5)
                    {
                        case "a":
                            s.FS4_5 = "Not eaten";
                            break;
                        case "b":
                            s.FS4_5 = "1 day";
                            break;
                        case "c":
                            s.FS4_5 = "2 days";
                            break;
                        case "d":
                            s.FS4_5 = "3 days";
                            break;
                        case "e":
                            s.FS4_5 = "4 days";
                            break;
                        case "f":
                            s.FS4_5 = "5 days";
                            break;
                        case "g":
                            s.FS4_5 = "6 days";
                            break;
                        case "h":
                            s.FS4_5 = "7 days";
                            break;
                    }

                    //Sync FS4_6
                    switch (s.FS4_6)
                    {
                        case "a":
                            s.FS4_6 = "Not eaten";
                            break;
                        case "b":
                            s.FS4_6 = "1 day";
                            break;
                        case "c":
                            s.FS4_6 = "2 days";
                            break;
                        case "d":
                            s.FS4_6 = "3 days";
                            break;
                        case "e":
                            s.FS4_6 = "4 days";
                            break;
                        case "f":
                            s.FS4_6 = "5 days";
                            break;
                        case "g":
                            s.FS4_6 = "6 days";
                            break;
                        case "h":
                            s.FS4_6 = "7 days";
                            break;
                    }

                    //Sync FS4_7
                    switch (s.FS4_7)
                    {
                        case "a":
                            s.FS4_7 = "Not eaten";
                            break;
                        case "b":
                            s.FS4_7 = "1 day";
                            break;
                        case "c":
                            s.FS4_7 = "2 days";
                            break;
                        case "d":
                            s.FS4_7 = "3 days";
                            break;
                        case "e":
                            s.FS4_7 = "4 days";
                            break;
                        case "f":
                            s.FS4_7 = "5 days";
                            break;
                        case "g":
                            s.FS4_7 = "6 days";
                            break;
                        case "h":
                            s.FS4_7 = "7 days";
                            break;
                    }

                    //Sync FS4_8
                    switch (s.FS4_8)
                    {
                        case "a":
                            s.FS4_8 = "Not eaten";
                            break;
                        case "b":
                            s.FS4_8 = "1 day";
                            break;
                        case "c":
                            s.FS4_8 = "2 days";
                            break;
                        case "d":
                            s.FS4_8 = "3 days";
                            break;
                        case "e":
                            s.FS4_8 = "4 days";
                            break;
                        case "f":
                            s.FS4_8 = "5 days";
                            break;
                        case "g":
                            s.FS4_8 = "6 days";
                            break;
                        case "h":
                            s.FS4_8 = "7 days";
                            break;
                    }

                    if (s.FS3.Contains("a"))
                        s.FS3_a = "Borrow Food, or rely on help from friends";
                    if (s.FS3.Contains("b"))
                        s.FS3_b = "Purchase food on debts";
                    if (s.FS3.Contains("c"))
                        s.FS3_c = "Limit portion size at meals";
                    if (s.FS3.Contains("d"))
                        s.FS3_d = "Selling domestic items including jewelries";
                    if (s.FS3.Contains("e"))
                        s.FS3_e = "Decrease expenses on health care";
                    if (s.FS3.Contains("f"))
                        s.FS3_f = "Adult ate less in order to make food available to children";
                    if (s.FS3.Contains("g"))
                        s.FS3_g = "Took children out of shcool for work";
                    if (s.FS3.Contains("h"))
                        s.FS3_h = "Rely on less preffered food";
                    if (s.FS3.Contains("i"))
                        s.FS3_i = "Skipped entire day meal";
                    if (s.FS3.Contains("j"))
                        s.FS3_j = "Did begging";
                    if (s.FS3.Contains("k"))
                        s.FS3_k = "Women ate less food than men";
                    if (s.FS3.Contains("l"))
                        s.FS3_l = "Sent family members to work abroad";
                    if (s.FS3.Contains("m"))
                        s.FS3_m = "Selling of assets";
                    if (s.FS3.Contains("n"))
                        s.FS3_n = "None of these";

                    //sync FS6
                    switch (s.FS6)
                    {
                        case "a":
                            s.FS6 = "Yes";
                            break;
                        case "b":
                            s.FS6 = "No";
                            break;
                    }

                    //sync FS7
                    switch (s.FS7)
                    {
                        case "a":
                            s.FS7 = "Yes";
                            break;
                        case "b":
                            s.FS7 = "No";
                            break;
                    }

                    //sync N1
                    switch (s.N1)
                    {
                        case "a":
                            s.N1 = "Within 1 hr";
                            break;
                        case "b":
                            s.N1 = "Between 1 hour and 24 hrs";
                            break;
                        case "c":
                            s.N1 = "Between 1 and 3 days";
                            break;
                        case "d":
                            s.N1 = "After the first 3 days";
                            break;
                        case "e":
                            s.N1 = "Never put to breast";
                            break;
                        case "f":
                            s.N1 = "Do not know";
                            break;
                    }

                    //sync N2 
                    switch (s.N2)
                    {
                        case "a":
                            s.N2 = "Age in Days";
                            break;
                        case "b":
                            s.N2 = "Age in Months";
                            break;
                        case "c":
                            s.N2 = "Never exclusively breastfed";
                            break;
                        case "d":
                            s.N2 = "Dont know";
                            break;
                    }

                    switch (s.N3)
                    {
                        case "a":
                            s.N3 = "Not yet";
                            break;
                        case "b":
                            s.N3 = "Less than a month after birth";
                            break;
                        case "c":
                            s.N3 = "Between 1 to 4 months";
                            break;
                        case "d":
                            s.N3 = "Between 4 to 6 months";
                            break;
                        case "e":
                            s.N3 = "More than 6 months";
                            break;
                        case "f":
                            s.N3 = "Dont know";
                            break;
                    }

                    switch (s.N4)
                    {
                        case "a":
                            s.N4 = "No change";
                            break;
                        case "b":
                            s.N4 = "Decreased";
                            break;
                        case "c":
                            s.N4 = "Stopped";
                            break;
                        case "d":
                            s.N4 = "Increased";
                            break;
                        case "e":
                            s.N4 = "Dont know";
                            break;
                    }

                    switch (s.N5)
                    {
                        case "a":
                            s.N5 = "Lack of privacy and space";
                            break;
                        case "b":
                            s.N5 = "Insufficient breast milk";
                            break;
                        case "c":
                            s.N5 = "Mother died";
                            break;
                        case "d":
                            s.N5 = "Mother sickness";
                            break;
                        case "e":
                            s.N5 = "Other";
                            break;
                        case "f":
                            s.N5 = "Dont know";
                            break;
                    }

                    //sync N6
                    if (s.N6.Contains("a"))
                    {
                        s.N6_a = "Specialized infant formula";
                    }
                    if (s.N6.Contains("b"))
                    {
                        s.N6_b = "Dried milk powder";
                    }
                    if (s.N6.Contains("c"))
                    {
                        s.N6_c = "Liquid milk";
                    }
                    if (s.N6.Contains("d"))
                    {
                        s.N6_d = "Liquid (Other than milk)";
                    }

                    //sync E1 
                    switch (s.E1)
                    {
                        case "a":
                            s.E1 = "Yes";
                            break;
                        case "b":
                            s.E1 = "No";
                            break;
                        case "c":
                            s.E1 = "Not applicable";
                            break;
                    }
                    //sync E2 
                    switch (s.E2)
                    {
                        case "a":
                            s.E2 = "Yes";
                            break;
                        case "b":
                            s.E2 = "No";
                            break;
                        case "b":
                            s.E2 = "Not applicable";
                            break;
                    }



                    if (s.E2c.Contains("a"))
                        s.E2c_a = "Goes to Madrassa";
                    if (s.E2c.Contains("b"))
                        s.E2c_b = "Cultural Issues (No separate Schools for girls, Gender Discrimination).";
                    if (s.E2c.Contains("c"))
                        s.E2c_c = "Schools is not secure";
                    if (s.E2c.Contains("d"))
                        s.E2c_d = "School is at long distance";
                    if (s.E2c.Contains("e"))
                        s.E2c_e = "Have no money for School fee, for books/ copies etc, for uniform.";
                    if (s.E2c.Contains("f"))
                        s.E2c_f = "Children are needed for domestic activities.";
                    if (s.E2c.Contains("g"))
                        s.E2c_g = "Child is disabled";
                    if (s.E2c.Contains("h"))
                        s.E2c_h = "Children were denied admissions because they are IDPs.";
                    if (s.E2c.Contains("i"))
                        s.E2c_i = "Child himself/ herself donot consider it important.";
                    if (s.E2c.Contains("j"))
                        s.E2c_j = "Parents consider their children underage.";
                    if (s.E2c.Contains("k"))
                        s.E2c_k = "Lack of documentation for enrollment (eg. academic certificates, CNIC of parents, birth certificates)";
                    if (s.E2c.Contains("l"))
                        s.E2c_l = "Child labor";

                    //sync E3
                    if (s.E3.Contains("a"))
                        s.E3_a = "Absence of staff";
                    if (s.E3.Contains("b"))
                        s.E3_b = "Children treated differently because of IDPs";
                    if (s.E3.Contains("c"))
                        s.E3_c = "Shortage of adequate school infrastructure (furniture, study material, proper class room)";
                    if (s.E3.Contains("d"))
                        s.E3_d = "Children are involved by the school administration in activities other than related to education.";
                    if (s.E3.Contains("e"))
                        s.E3_e = "Unavailability of female staff";
                    if (s.E3.Contains("f"))
                        s.E3_f = "Other";
                    if (s.E3.Contains("g"))
                        s.E3_g = "None";
                    if (s.E3.Contains("h"))
                        s.E3_h = "Not applicable";

                    //sync SH1
                    switch (s.SH1)
                    {
                        case "a":
                            s.SH1 = "Owned";
                            break;
                        case "b":
                            s.SH1 = "With relatives/friends";
                            break;
                        case "c":
                            s.SH1 = "Rented";
                            break;
                        case "d":
                            s.SH1 = "Open Air";
                            break;
                    }

                    //sync SH6
                    switch (s.SH6)
                    {
                        case "a":
                            s.SH6 = "Excellent";
                            break;
                        case "b":
                            s.SH6 = "Average";
                            break;
                        case "c":
                            s.SH6 = "Poor";
                            break;
                    }

                    //sync SH6
                    //switch (s.SH6)
                    //{
                    //    case "a":
                    //        s.SH6 = "Excellent";
                    //        break;
                    //    case "b":
                    //        s.SH6 = "Average";
                    //        break;
                    //    case "c":
                    //        s.SH6 = "Poor";
                    //        break;
                    //}

                    //sync SH7
                    switch (s.SH7)
                    {
                        case "a":
                            s.SH7 = "Excellent";
                            break;
                        case "b":
                            s.SH7 = "Average";
                            break;
                        case "c":
                            s.SH7 = "Poor";
                            break;
                    }

                    //sync SH9
                    switch (s.SH9)
                    {
                        case "a":
                            s.SH9 = "Yes";
                            break;
                        case "b":
                            s.SH9 = "No";
                            break;
                    }

                    //sync SH8
                    if (s.SH8.Contains("a"))
                    {
                        s.SH8_a = "Fridge/Freezer";
                    }
                    if (s.SH8.Contains("b"))
                    {
                        s.SH8_b = "TV";
                    }
                    if (s.SH8.Contains("c"))
                    {
                        s.SH8_c = "Radio";
                    }
                    if (s.SH8.Contains("d"))
                    {
                        s.SH8_d = "Microwave Oven";
                    }
                    if (s.SH8.Contains("e"))
                    {
                        s.SH8_e = "Cooking Stove";
                    }
                    if (s.SH8.Contains("f"))
                    {
                        s.SH8_f = "Heater";
                    }
                    if (s.SH8.Contains("g"))
                    {
                        s.SH8_g = "Washing machine";
                    }
                    if (s.SH8.Contains("h"))
                    {
                        s.SH8_h = "Sewing machine";
                    }
                    if (s.SH8.Contains("i"))
                    {
                        s.SH8_i = "Car/Truck/Taxi";
                    }
                    if (s.SH8.Contains("j"))
                    {
                        s.SH8_j = "Motorbike";
                    }
                    if (s.SH8.Contains("k"))
                    {
                        s.SH8_k = "Bicycle";
                    }
                    if (s.SH8.Contains("l"))
                    {
                        s.SH8_l = "Computer";
                    }
                    if (s.SH8.Contains("m"))
                    {
                        s.SH8_m = "Grain mill";
                    }
                    if (s.SH8.Contains("n"))
                    {
                        s.SH8_n = "Plough";
                    }
                    if (s.SH8.Contains("o"))
                    {
                        s.SH8_o = "Other form of machinery";
                    }
                    if (s.SH8.Contains("p"))
                    {
                        s.SH8_p = "None of these";
                    }


                    switch (s.W1)
                    {
                        case "a":
                            s.W1 = "Protected (hand pump, Pipe water, protected well)";
                            break;
                        case "b":
                            s.W1 = "Unprotected (canal, river, open well, surface water, unprotected well)";
                            break;
                    }

                    switch (s.W2)
                    {
                        case "a":
                            s.W2 = "Available inside Home";
                            break;
                        case "b":
                            s.W2 = "Under 500 meters";
                            break;
                        case "c":
                            s.W2 = "500 to 800 meter";
                            break;
                        case "d":
                            s.W2 = "Over 800 meter";
                            break;
                    }


                    if (s.W7.Contains("a"))
                        s.W7_a = "Male";
                    if (s.W7.Contains("b"))
                        s.W7_b = "Female";
                    if (s.W7.Contains("c"))
                        s.W7_c = "Children";

                    //switch (s.W7)
                    //{
                    //    case "a":
                    //        s.W7 = "Male";
                    //        break;
                    //    case "b":
                    //        s.W7 = "Female";
                    //        break;
                    //    case "c":
                    //        s.W7 = "Children";
                    //        break;
                    //}

                    //W5
                    switch (s.W5)
                    {
                        case "a":
                            s.W5 = "Yes";
                            break;
                        case "b":
                            s.W5 = "No";
                            break;
                    }

                    //W3
                    switch (s.W3)
                    {
                        case "a":
                            s.W3 = "Open defecation";
                            break;
                        case "b":
                            s.W3 = "Latrine at home (formal)";
                            break;
                        case "c":
                            s.W3 = "Latrine at home (informal)";
                            break;
                        case "d":
                            s.W3 = "Community/Shared Latrine";
                            break;
                    }

                    //sync W3a
                    switch (s.W3a)
                    {
                        case "a":
                            s.W3a = "Yes";
                            break;
                        case "b":
                            s.W3a = "No";
                            break;
                    }

                    //sync W3b 
                    switch (s.W3b)
                    {
                        case "a":
                            s.W3b = "Less than 5";
                            break;
                        case "b":
                            s.W3b = "5 - 10";
                            break;
                        case "c":
                            s.W3b = "10 - 15";
                            break;
                        case "d":
                            s.W3b = "More than 15";
                            break;
                    }

                    //sync W4
                    switch (s.W4)
                    {
                        case "a":
                            s.W4 = "Yes";
                            break;
                        case "b":
                            s.W4 = "No";
                            break;
                    }

                    //sync H1
                    switch (s.H1)
                    {
                        case "a":
                            s.H1 = "Yes";
                            break;
                        case "b":
                            s.H1 = "No";
                            break;
                    }

                    //sync H1a
                    if (s.H1a.Contains("a"))
                        s.H1a_a = "OPD Services";
                    if (s.H1a.Contains("b"))
                        s.H1a_b = "Free medicines";
                    if (s.H1a.Contains("c"))
                        s.H1a_c = "Hospitilization";
                    if (s.H1a.Contains("d"))
                        s.H1a_d = "Family planning";
                    if (s.H1a.Contains("e"))
                        s.H1a_e = "None";
                    if (s.H1a.Contains("f"))
                        s.H1a_f = "Other";

                    //sync H1b
                    if (s.H1b.Contains("a"))
                        s.H1b_a = "Unavailability of staff";
                    if (s.H1b.Contains("b"))
                        s.H1b_b = "Uavailability of female staff";
                    if (s.H1b.Contains("c"))
                        s.H1b_c = "Unavailability of medicines";
                    if (s.H1b.Contains("d"))
                        s.H1b_d = "Miss treatment because of IDPs status";
                    if (s.H1b.Contains("e"))
                        s.H1b_e = "Charge money for services (OPD services, hospitalization, medication etc)";
                    if (s.H1b.Contains("f"))
                        s.H1b_f = "Heavy amount charged in emergency/ critical situations";
                    if (s.H1b.Contains("g"))
                        s.H1b_g = "None";
                    if (s.H1b.Contains("h"))
                        s.H1b_h = "Other";


                    //sync H1c
                    if (s.H1c.Contains("a"))
                        s.H1c_a = "Security";
                    if (s.H1c.Contains("b"))
                        s.H1c_b = "Financial";
                    if (s.H1c.Contains("c"))
                        s.H1c_c = "Long distance";
                    if (s.H1c.Contains("d"))
                        s.H1c_d = "Difficult Terrain";
                    if (s.H1c.Contains("e"))
                        s.H1c_e = "Cultural/Social constraints";
                    if (s.H1c.Contains("f"))
                        s.H1c_f = "Not aware of the government facility";
                    if (s.H1c.Contains("g"))
                        s.H1c_g = "Others";

                    //sync H3
                    if (s.H3.Contains("a"))
                        s.H3_a = "Pregnant";
                    if (s.H3.Contains("b"))
                        s.H3_b = "Lactacting";
                    if (s.H3.Contains("c"))
                        s.H3_c = "None";
                    if (s.H3.Contains("d"))
                        s.H3_d = "Not Applicable";


                    //sync H3a
                    if (s.H3a.Contains("a"))
                        s.H3a_a = "Lady Doctors, Lady Health Visitor (LHV), Community Mid Wives";
                    if (s.H3a.Contains("b"))
                        s.H3a_b = "Traditional Birth Attendants (Dai etc)";
                    if (s.H3a.Contains("c"))
                        s.H3a_c = "No access";

                    //sync H4
                    if (s.H4.Contains("a"))
                        s.H4_1 = "Women (Against TT)";
                    if (s.H4.Contains("b"))
                        s.H4_2 = "Children (Routine EPI)";
                    if (s.H4.Contains("c"))
                        s.H4_3 = "None";
                    if (s.H4.Contains("d"))
                        s.H4_4 = "Not applicable";

                    //sync H4a
                    if (s.H4a.Contains("a"))
                        s.H4a_a = "Lack of services";
                    if (s.H4a.Contains("b"))
                        s.H4a_b = "Access of issues";
                    if (s.H4a.Contains("c"))
                        s.H4a_c = "Social/Cultural constraints";
                    if (s.H4a.Contains("d"))
                        s.H4a_d = "Lack of awareness";
                    if (s.H4a.Contains("e"))
                        s.H4a_e = "Others";


                    //sync H5
                    if (s.H5.Contains("a"))
                        s.H5_a = "Bed nets";
                    if (s.H5.Contains("b"))
                        s.H5_b = "Indoor/Outdoor insecticidial spray";
                    if (s.H5.Contains("c"))
                        s.H5_c = "Repellants use by an individual";
                    if (s.H5.Contains("d"))
                        s.H5_d = "Others";
                    if (s.H5.Contains("e"))
                        s.H5_e = "None";

                    //sync IS5 
                    switch (s.IS5)
                    {
                        case "a":
                            s.IS5 = "Settle where you live now";
                            break;
                        case "b":
                            s.IS5 = "Settle in another place";
                            break;
                    }

                    switch (s.IS8a)
                    {
                        case "a":
                            s.IS8a = "Security during travel";
                            break;
                        case "b":
                            s.IS8a = "Security in area of origin";
                            break;
                        case "c":
                            s.IS8a = "Transportation";
                            break;
                        case "d":
                            s.IS8a = "Food";
                            break;
                        case "e":
                            s.IS8a = "Water";
                            break;
                        case "f":
                            s.IS8a = "Temporary Shelter";
                            break;
                        case "g":
                            s.IS8a = "Material for rebuilding house";
                            break;
                        case "h":
                            s.IS8a = "Agriculture and farming";
                            break;
                        case "i":
                            s.IS8a = "Educational Services";
                            break;
                        case "j":
                            s.IS8a = "Job opportunities";
                            break;
                        case "k":
                            s.IS8a = "Health Services";
                            break;
                        case "l":
                            s.IS8a = "Livelihood training";
                            break;
                        case "m":
                            s.IS8a = "Assistance with rent";
                            break;
                        case "n":
                            s.IS8a = "Electricity";
                            break;
                        case "o":
                            s.IS8a = "Non Food Items (NFI)";
                            break;
                        case "p":
                            s.IS8a = "None";
                            break;
                        case "q":
                            s.IS8a = "Other";
                            break;
                    }

                    switch (s.IS8b)
                    {
                        case "a":
                            s.IS8b = "Security during travel";
                            break;
                        case "b":
                            s.IS8b = "Security in area of origin";
                            break;
                        case "c":
                            s.IS8b = "Transportation";
                            break;
                        case "d":
                            s.IS8b = "Food";
                            break;
                        case "e":
                            s.IS8b = "Water";
                            break;
                        case "f":
                            s.IS8b = "Temporary Shelter";
                            break;
                        case "g":
                            s.IS8b = "Material for rebuilding house";
                            break;
                        case "h":
                            s.IS8b = "Agriculture and farming";
                            break;
                        case "i":
                            s.IS8b = "Educational Services";
                            break;
                        case "j":
                            s.IS8b = "Job opportunities";
                            break;
                        case "k":
                            s.IS8b = "Health Services";
                            break;
                        case "l":
                            s.IS8b = "Livelihood training";
                            break;
                        case "m":
                            s.IS8b = "Assistance with rent";
                            break;
                        case "n":
                            s.IS8b = "Electricity";
                            break;
                        case "o":
                            s.IS8b = "Non Food Items (NFI)";
                            break;
                        case "p":
                            s.IS8b = "None";
                            break;
                        case "q":
                            s.IS8b = "Other";
                            break;
                    }

                    switch (s.IS8c)
                    {
                        case "a":
                            s.IS8c = "Security during travel";
                            break;
                        case "b":
                            s.IS8c = "Security in area of origin";
                            break;
                        case "c":
                            s.IS8c = "Transportation";
                            break;
                        case "d":
                            s.IS8c = "Food";
                            break;
                        case "e":
                            s.IS8c = "Water";
                            break;
                        case "f":
                            s.IS8c = "Temporary Shelter";
                            break;
                        case "g":
                            s.IS8c = "Material for rebuilding house";
                            break;
                        case "h":
                            s.IS8c = "Agriculture and farming";
                            break;
                        case "i":
                            s.IS8c = "Educational Services";
                            break;
                        case "j":
                            s.IS8c = "Job opportunities";
                            break;
                        case "k":
                            s.IS8c = "Health Services";
                            break;
                        case "l":
                            s.IS8c = "Livelihood training";
                            break;
                        case "m":
                            s.IS8c = "Assistance with rent";
                            break;
                        case "n":
                            s.IS8c = "Electricity";
                            break;
                        case "o":
                            s.IS8c = "Non Food Items (NFI)";
                            break;
                        case "p":
                            s.IS8c = "None";
                            break;
                        case "q":
                            s.IS8c = "Other";
                            break;
                    }

                    switch (s.IS7a)
                    {
                        case "a":
                            s.IS7a = "Security at the current place";
                            break;
                        case "b":
                            s.IS7a = "Food";
                            break;
                        case "c":
                            s.IS7a = "Water";
                            break;
                        case "d":
                            s.IS7a = "Temporary shelter";
                            break;
                        case "e":
                            s.IS7a = "Agriculture and farming";
                            break;
                        case "f":
                            s.IS7a = "Educational Services";
                            break;
                        case "g":
                            s.IS7a = "Job opportunities";
                            break;
                        case "h":
                            s.IS7a = "Health services";
                            break;
                        case "i":
                            s.IS7a = "Livelihood training";
                            break;
                        case "j":
                            s.IS7a = "Assistance with rent";
                            break;
                        case "k":
                            s.IS7a = "Utilities(electricity, water, gas)";
                            break;
                        case "l":
                            s.IS7a = "Non Food Items(NFI)";
                            break;
                        case "m":
                            s.IS7a = "Documentation";
                            break;
                        case "n":
                            s.IS7a = "None";
                            break;
                        case "o":
                            s.IS7a = "Other";
                            break;
                    }

                    switch (s.IS7b)
                    {
                        case "a":
                            s.IS7b = "Security at the current place";
                            break;
                        case "b":
                            s.IS7b = "Food";
                            break;
                        case "c":
                            s.IS7b = "Water";
                            break;
                        case "d":
                            s.IS7b = "Temporary shelter";
                            break;
                        case "e":
                            s.IS7b = "Agriculture and farming";
                            break;
                        case "f":
                            s.IS7b = "Educational Services";
                            break;
                        case "g":
                            s.IS7b = "Job opportunities";
                            break;
                        case "h":
                            s.IS7b = "Health services";
                            break;
                        case "i":
                            s.IS7b = "Livelihood training";
                            break;
                        case "j":
                            s.IS7b = "Assistance with rent";
                            break;
                        case "k":
                            s.IS7b = "Utilities(electricity, water, gas)";
                            break;
                        case "l":
                            s.IS7b = "Non Food Items(NFI)";
                            break;
                        case "m":
                            s.IS7b = "Documentation";
                            break;
                        case "n":
                            s.IS7b = "None";
                            break;
                        case "o":
                            s.IS7b = "Other";
                            break;
                    }

                    switch (s.IS7c)
                    {
                        case "a":
                            s.IS7c = "Security at the current place";
                            break;
                        case "b":
                            s.IS7c = "Food";
                            break;
                        case "c":
                            s.IS7c = "Water";
                            break;
                        case "d":
                            s.IS7c = "Temporary shelter";
                            break;
                        case "e":
                            s.IS7c = "Agriculture and farming";
                            break;
                        case "f":
                            s.IS7c = "Educational Services";
                            break;
                        case "g":
                            s.IS7c = "Job opportunities";
                            break;
                        case "h":
                            s.IS7c = "Health services";
                            break;
                        case "i":
                            s.IS7c = "Livelihood training";
                            break;
                        case "j":
                            s.IS7c = "Assistance with rent";
                            break;
                        case "k":
                            s.IS7c = "Utilities(electricity, water, gas)";
                            break;
                        case "l":
                            s.IS7c = "Non Food Items(NFI)";
                            break;
                        case "m":
                            s.IS7c = "Documentation";
                            break;
                        case "n":
                            s.IS7c = "None";
                            break;
                        case "o":
                            s.IS7c = "Other";
                            break;
                    }


                    switch (s.IS6a)
                    {
                        case "a":
                            s.IS6a = "Security during travel";
                            break;
                        case "b":
                            s.IS6a = "Security at destination";
                            break;
                        case "c":
                            s.IS6a = "Transportation";
                            break;
                        case "d":
                            s.IS6a = "Food";
                            break;
                        case "e":
                            s.IS6a = "Water";
                            break;
                        case "f":
                            s.IS6a = "Temporary shelter";
                            break;
                        case "g":
                            s.IS6a = "Agriculture and Farming";
                            break;
                        case "h":
                            s.IS6a = "Educational Services";
                            break;
                        case "i":
                            s.IS6a = "Job opportunities";
                            break;
                        case "j":
                            s.IS6a = "Health Services";
                            break;
                        case "k":
                            s.IS6a = "Livelihood training";
                            break;
                        case "l":
                            s.IS6a = "Assistance with rent";
                            break;
                        case "m":
                            s.IS6a = "Utilities (electricity, water, gas)";
                            break;
                        case "n":
                            s.IS6a = "Non Food Items(NFI)";
                            break;
                        case "o":
                            s.IS6a = "None";
                            break;
                        case "p":
                            s.IS6a = "Other";
                            break;
                    }

                    switch (s.IS6b)
                    {
                        case "a":
                            s.IS6b = "Security during travel";
                            break;
                        case "b":
                            s.IS6b = "Security at destination";
                            break;
                        case "c":
                            s.IS6b = "Transportation";
                            break;
                        case "d":
                            s.IS6b = "Food";
                            break;
                        case "e":
                            s.IS6b = "Water";
                            break;
                        case "f":
                            s.IS6b = "Temporary shelter";
                            break;
                        case "g":
                            s.IS6b = "Agriculture and Farming";
                            break;
                        case "h":
                            s.IS6b = "Educational Services";
                            break;
                        case "i":
                            s.IS6b = "Job opportunities";
                            break;
                        case "j":
                            s.IS6b = "Health Services";
                            break;
                        case "k":
                            s.IS6b = "Livelihood training";
                            break;
                        case "l":
                            s.IS6b = "Assistance with rent";
                            break;
                        case "m":
                            s.IS6b = "Utilities (electricity, water, gas)";
                            break;
                        case "n":
                            s.IS6b = "Non Food Items(NFI)";
                            break;
                        case "o":
                            s.IS6b = "None";
                            break;
                        case "p":
                            s.IS6b = "Other";
                            break;
                    }

                    switch (s.IS6c)
                    {
                        case "a":
                            s.IS6c = "Security during travel";
                            break;
                        case "b":
                            s.IS6c = "Security at destination";
                            break;
                        case "c":
                            s.IS6c = "Transportation";
                            break;
                        case "d":
                            s.IS6c = "Food";
                            break;
                        case "e":
                            s.IS6c = "Water";
                            break;
                        case "f":
                            s.IS6c = "Temporary shelter";
                            break;
                        case "g":
                            s.IS6c = "Agriculture and Farming";
                            break;
                        case "h":
                            s.IS6c = "Educational Services";
                            break;
                        case "i":
                            s.IS6c = "Job opportunities";
                            break;
                        case "j":
                            s.IS6c = "Health Services";
                            break;
                        case "k":
                            s.IS6c = "Livelihood training";
                            break;
                        case "l":
                            s.IS6c = "Assistance with rent";
                            break;
                        case "m":
                            s.IS6c = "Utilities (electricity, water, gas)";
                            break;
                        case "n":
                            s.IS6c = "Non Food Items(NFI)";
                            break;
                        case "o":
                            s.IS6c = "None";
                            break;
                        case "p":
                            s.IS6c = "Other";
                            break;
                    }

                    //sync SH5a 
                    switch (s.SH5a)
                    {
                        case "a":
                            s.SH5a = "Overcrowding/ privacy in accommodation";
                            break;
                        case "b":
                            s.SH5a = "Security";
                            break;
                        case "c":
                            s.SH5a = "Access to services (health, schools)";
                            break;
                        case "d":
                            s.SH5a = "Harsh weather conditions";
                            break;
                        case "e":
                            s.SH5a = "Lack of water and sanitation";
                            break;
                        case "f":
                            s.SH5a = "Lack of cooking facilities";
                            break;
                        case "g":
                            s.SH5a = "High cost of goods/services";
                            break;
                        case "h":
                            s.SH5a = "Lack of money";
                            break;
                        case "i":
                            s.SH5a = "No access to income earning opportunities";
                            break;
                        case "j":
                            s.SH5a = "Lack of food";
                            break;
                        case "k":
                            s.SH5a = "Other";
                            break;
                        case "l":
                            s.SH5a = "None";
                            break;
                    }


                    //sync SH5b 
                    switch (s.SH5b)
                    {
                        case "a":
                            s.SH5b = "Overcrowding/ privacy in accommodation";
                            break;
                        case "b":
                            s.SH5b = "Security";
                            break;
                        case "c":
                            s.SH5b = "Access to services (health, schools)";
                            break;
                        case "d":
                            s.SH5b = "Harsh weather conditions";
                            break;
                        case "e":
                            s.SH5b = "Lack of water and sanitation";
                            break;
                        case "f":
                            s.SH5b = "Lack of cooking facilities";
                            break;
                        case "g":
                            s.SH5b = "High cost of goods/services";
                            break;
                        case "h":
                            s.SH5b = "Lack of money";
                            break;
                        case "i":
                            s.SH5b = "No access to income earning opportunities";
                            break;
                        case "j":
                            s.SH5b = "Lack of food";
                            break;
                        case "k":
                            s.SH5b = "Other";
                            break;
                        case "l":
                            s.SH5b = "None";
                            break;
                    }


                    //sync SH5c 
                    switch (s.SH5c)
                    {
                        case "a":
                            s.SH5c = "Overcrowding/ privacy in accommodation";
                            break;
                        case "b":
                            s.SH5c = "Security";
                            break;
                        case "c":
                            s.SH5c = "Access to services (health, schools)";
                            break;
                        case "d":
                            s.SH5c = "Harsh weather conditions";
                            break;
                        case "e":
                            s.SH5c = "Lack of water and sanitation";
                            break;
                        case "f":
                            s.SH5c = "Lack of cooking facilities";
                            break;
                        case "g":
                            s.SH5c = "High cost of goods/services";
                            break;
                        case "h":
                            s.SH5c = "Lack of money";
                            break;
                        case "i":
                            s.SH5c = "No access to income earning opportunities";
                            break;
                        case "j":
                            s.SH5c = "Lack of food";
                            break;
                        case "k":
                            s.SH5c = "Other";
                            break;
                        case "l":
                            s.SH5c = "None";
                            break;
                    }

                    switch (s.IC)
                    {
                        case "a":
                            s.IC = "With the humanitarian community and government";
                            break;
                        case "b":
                            s.IC = "With humanitarian community only";
                            break;
                        case "c":
                            s.IC = "Not shared with either humanitarian community or government";
                            break;
                        case "d":
                            s.IC = "Share with government only";
                            break;
                    }


                    synced.Add(s);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Count: " + synced.Count.ToString());
            return synced;

        }

        /// <summary>
        /// Sync UnsyncedKI file
        /// </summary>
        /// <param name="unsyncedFile"></param>
        /// <returns></returns>
        public List<SyncedKI> SyncKeyInformantFile(List<UnscyncedKI> unsyncedFile)
        {
            List<SyncedKI> synced = new List<SyncedKI>();
            foreach (UnscyncedKI u in unsyncedFile)
            {
                SyncedKI s = new SyncedKI();
                s = AutoMapper.Mapper.Map<SyncedKI>(u);

                //Begin Biohazard Syncing operation
                //sync occupation
                if (s.occupation.Contains("a"))
                {
                    s.occupation_a = "Teacher";
                }
                if (s.occupation.Contains("b"))
                {
                    s.occupation_b = "Mosque Leader";
                }
                if (s.occupation.Contains("c"))
                {
                    s.occupation_c = "Community Leader";
                }
                if (s.occupation.Contains("d"))
                {
                    s.occupation_d = "Tribal Leader";
                }
                if (s.occupation.Contains("e"))
                {
                    s.occupation_e = "Health Care Provider";
                }
                if (s.occupation.Contains("f"))
                {
                    s.occupation_f = "Others";
                }


                //sync no_BHU
                if (s.no_BHU.Contains("a"))
                {
                    s.no_BHU_a = "Unavailability of doctors";
                }
                if (s.no_BHU.Contains("b"))
                {
                    s.no_BHU_b = "Unavailability of nurses";
                }
                if (s.no_BHU.Contains("c"))
                {
                    s.no_BHU_c = "Unavailability of administrational staff";
                }
                if (s.no_BHU.Contains("d"))
                {
                    s.no_BHU_d = "Unavailability of BHU";
                }
                if (s.no_BHU.Contains("e"))
                {
                    s.no_BHU_e = "Unavailability of services";
                }
                if (s.no_BHU.Contains("f"))
                {
                    s.no_BHU_f = "Other";
                }


                //sync health_problem
                if (s.health_problem.Contains("a"))
                {
                    s.health_problem_a = "Unavailability of health facilities";

                }
                if (s.health_problem.Contains("b"))
                {
                    s.health_problem_b = "Unavailability of medicines";
                }
                if (s.health_problem.Contains("c"))
                {
                    s.health_problem_c = "Unavailability of staff (doctors, nurses, administrational)";
                }
                if (s.health_problem.Contains("d"))
                {
                    s.health_problem_d = "Child health issues";
                }
                if (s.health_problem.Contains("e"))
                {
                    s.health_problem_e = "Women health issues";
                }
                if (s.health_problem.Contains("f"))
                {
                    s.health_problem_f = "Water pollution";
                }
                if (s.health_problem.Contains("g"))
                {
                    s.health_problem_g = "Environmental pollution";
                }
                if (s.health_problem.Contains("h"))
                {
                    s.health_problem_h = "Cleanliness/hygiene";
                }
                if (s.health_problem.Contains("i"))
                {
                    s.health_problem_i = "Others";
                }

                //sync school_setup
                if (s.school_setup.Contains("a"))
                {
                    s.school_setup_a = "Strong accountability (checks/balance) system";
                }
                if (s.school_setup.Contains("b"))
                {
                    s.school_setup_b = "Increase number of Staff members (Teaching and Administration)";
                }
                if (s.school_setup.Contains("c"))
                {
                    s.school_setup_c = "Provision of infrastructure facilities (furniture, study material, proper class room";
                }
                if (s.school_setup.Contains("d"))
                {
                    s.school_setup_d = "Focus more on quality education for children";
                }
                if (s.school_setup.Contains("e"))
                {
                    s.school_setup_e = "Others";
                }


                //sync danger_zone
                if (s.danger_zone.Contains("a"))
                {
                    s.danger_zone_a = "In transit to market";
                }
                if (s.danger_zone.Contains("b"))
                {
                    s.danger_zone_b = "While using public transit";
                }
                if (s.danger_zone.Contains("c"))
                {
                    s.danger_zone_c = "Water collection points";
                }
                if (s.danger_zone.Contains("d"))
                {
                    s.danger_zone_d = "Bathing points";
                }
                if (s.danger_zone.Contains("e"))
                {
                    s.danger_zone_e = "While working in the field";
                }
                if (s.danger_zone.Contains("f"))
                {
                    s.danger_zone_f = "In the health facility";
                }
                if (s.danger_zone.Contains("g"))
                {
                    s.danger_zone_g = "Market";
                }
                if (s.danger_zone.Contains("h"))
                {
                    s.danger_zone_h = "In transit to school";
                }
                if (s.danger_zone.Contains("i"))
                {
                    s.danger_zone_i = "School";
                }
                if (s.danger_zone.Contains("j"))
                {
                    s.danger_zone_j = "Don't Know";
                }
                if (s.danger_zone.Contains("k"))
                {
                    s.danger_zone_k = "None";
                }


                //sync violence
                if (s.violence.Contains("a"))
                {
                    s.violence_a = "Physical violence";
                }
                if (s.violence.Contains("b"))
                {
                    s.violence_b = "Verbal abuse";
                }
                if (s.violence.Contains("c"))
                {
                    s.violence_c = "Early marriages";
                }
                if (s.violence.Contains("d"))
                {
                    s.violence_d = "Social discrimination";
                }
                if (s.violence.Contains("e"))
                {
                    s.violence_e = "Domestic violence, Harassment, Lack of awareness of human rights";
                }
                if (s.violence.Contains("f"))
                {
                    s.violence_f = "Honor Killing";
                }
                if (s.violence.Contains("g"))
                {
                    s.violence_g = "None";
                }
                if (s.violence.Contains("h"))
                {
                    s.violence_h = "Dont Know";
                }
                if (s.violence.Contains("i"))
                {
                    s.violence_i = "Other";
                }


                //sync community
                if (s.community.Contains("a"))
                {
                    s.community_a = "On shelter";
                }
                if (s.community.Contains("b"))
                {
                    s.community_b = "On water";
                }
                if (s.community.Contains("c"))
                {
                    s.community_c = "Health";
                }
                if (s.community.Contains("d"))
                {
                    s.community_d = "Education";
                }
                if (s.community.Contains("e"))
                {
                    s.community_e = "None";
                }
                if (s.community.Contains("f"))
                {
                    s.community_f = "Other";
                }

                Console.WriteLine("Rent : " + s.rent);
                s.rent = s.rent.Replace('–', '-');
                Console.WriteLine("Rent : " + s.rent);
                synced.Add(s);
            }

            return synced;
        }

        /// <summary>
        /// Syncs verification Checklist
        /// </summary>
        /// <param name="unsycned"></param>
        /// <returns></returns>
        public List<SyncedVC> SyncVerificationChecklist(List<UnsyncedVC> unsycned)
        {
            List<SyncedVC> synced = new List<SyncedVC>();
            foreach (UnsyncedVC u in unsycned)
            {
                SyncedVC s = new SyncedVC();
                s = AutoMapper.Mapper.Map<SyncedVC>(u);
                if (s.verified_by.Contains("a"))
                {
                    s.verified_by_a = "Focal Person";
                }
                if (s.verified_by.Contains("b"))
                {
                    s.verified_by_b = "Tribe Leaders";
                }
                if (s.verified_by.Contains("c"))
                {
                    s.verified_by_c = "Community Elder";
                }
                if (s.verified_by.Contains("d"))
                {
                    s.verified_by_d = "Mosque_Leader (Molvi)";
                }
                if (s.verified_by.Contains("e"))
                {
                    s.verified_by_e = "Government/Administration";
                }
                if (s.verified_by.Contains("f"))
                {
                    s.verified_by_f = "Neighbors/ Other IDP families";
                }
                if (s.verified_by.Contains("g"))
                {
                    s.verified_by_g = "Others (if any)";
                }

                if (s.doc_type.Contains("a"))
                {
                    s.doc_type_a = "Registration Card";
                }
                if (s.doc_type.Contains("b"))
                {
                    s.doc_type_b = "Ration Card";
                }
                if (s.doc_type.Contains("c"))
                {
                    s.doc_type_c = "CNIC Token";
                }
                if (s.doc_type.Contains("d"))
                {
                    s.doc_type_d = "FDMA provided document";
                }
                if (s.doc_type.Contains("e"))
                {
                    s.doc_type_e = "Document from political administration";
                }
                if (s.doc_type.Contains("f"))
                {
                    s.doc_type_f = "Other";
                }

                synced.Add(s);
            }
            return synced;
        }

        /// <summary>
        /// Syncs the Survey file.
        /// </summary>
        /// <param name="unsyncedSurvey"></param>
        /// <returns></returns>
        public List<SyncedSurvey> SyncSurveyWithMagicalUnicorns(dynamic obj)
        {
            List<SyncedSurvey> synced = new List<SyncedSurvey>();
            //foreach (Survey us in unsyncedSurvey)
            //{
            //    //Lets map the objest first so we dont have to fill every value by hand. This operation is supported by magical unicorns riding rainbows in the sunset.
            //    SyncedSurvey s = new SyncedSurvey();
            //    s = AutoMapper.Mapper.Map<SyncedSurvey>(us);

            //    //Begin Biohazard Syncing Operation
            //    //Syncing TehsilF
            //    switch (s.TehsilF)
            //    {
            //        case "1":
            //            s.TehsilF = "Upper Kurram";
            //            break;
            //        case "2":
            //            s.TehsilF = "Central Kurram";
            //            break;
            //        case "3":
            //            s.TehsilF = "Lower Kurram";
            //            break;
            //        case "4":
            //            s.TehsilF = "Central Orakzai";
            //            break;
            //        case "5":
            //            s.TehsilF = "Ismailzai";
            //            break;
            //        case "6":
            //            s.TehsilF = "Lower Orakzai";
            //            break;
            //        case "7":
            //            us.TehsilF = "Upper Orakzai";
            //            break;
            //        case "8":
            //            s.TehsilF = "Bara";
            //            break;
            //        case "9":
            //            s.TehsilF = "Jamrud";
            //            break;
            //        case "10":
            //            s.TehsilF = "Landi Kotal";
            //            break;
            //        default:
            //            s.TehsilF = "";
            //            break;
            //    }

            //    //Sync District
            //    switch (s.District)
            //    {
            //        case "H":
            //            s.District = "Hangu";
            //            break;
            //        case "Ko":
            //            s.District = "Kohat";
            //            break;
            //        case "N":
            //            s.District = "Nowshera";
            //            break;
            //        case "P":
            //            s.District = "Peshawar";
            //            break;
            //        default:
            //            s.District = "";
            //            break;
            //    }

            //    //Sync Tehsil
            //    switch (s.Tehsil)
            //    {
            //        case "1":
            //            s.Tehsil = "Hangu";
            //            break;
            //        case "2":
            //            s.Tehsil = "Thall";
            //            break;
            //        case "3":
            //            s.Tehsil = "Lachi";
            //            break;
            //        case "4":
            //            s.Tehsil = "Kohat";
            //            break;
            //        case "5":
            //            s.Tehsil = "Peshawar (Town-I)";
            //            break;
            //        case "6":
            //            s.Tehsil = "Peshawar (Town-II)";
            //            break;
            //        case "7":
            //            s.Tehsil = "Peshawar (Town-III)";
            //            break;
            //        case "8":
            //            s.Tehsil = "Peshawar (Town-IV)";
            //            break;
            //        case "9":
            //            s.Tehsil = "Nowshera";
            //            break;
            //        case "10":
            //            s.Tehsil = "Pabbi";
            //            break;
            //        default:
            //            s.Tehsil = "";
            //            break;
            //    }

            //    //Start Syncing UCs
            //    switch (s.UC)
            //    {


            //        case "1":
            //            s.UC = "Darband";
            //            break;

            //        case "2":
            //            s.UC = "Balyamina";
            //            break;
            //        case "3":
            //            s.UC = "Ganjiano Kali (MC)";
            //            break;
            //        case "4":
            //            s.UC = "Kahi";
            //            break;
            //        case "5":
            //            s.UC = "Kech Banda";
            //            break;
            //        case "6":
            //            s.UC = "Khan Bari";
            //            break;
            //        case "7":
            //            s.UC = "Kotki";
            //            break;
            //        case "8":
            //            s.UC = "Muhammad Khawja";
            //            break;
            //        case "9":
            //            s.UC = "Raisan";
            //            break;
            //        case "10":
            //            s.UC = "Toghserai";
            //            break;
            //        case "11":
            //            s.UC = "Dallan";
            //            break;
            //        case "12":
            //            s.UC = "Darsamand";
            //            break;
            //        case "13":
            //            s.UC = "Doaba (Tc)";
            //            break;
            //        case "14":
            //            s.UC = "Doaba (Uc)";
            //            break;
            //        case "15":
            //            s.UC = "Karbogha";
            //            break;
            //        case "16":
            //            s.UC = "Naryab-II";
            //            break;
            //        case "17":
            //            s.UC = "Naryabi-I";
            //            break;
            //        case "18":
            //            s.UC = "Thall (Rural)";
            //            break;
            //        case "19":
            //            s.UC = "Thall (Urban)";
            //            break;
            //        case "20":
            //            s.UC = "Tora Warai";
            //            break;
            //        case "21":
            //            s.UC = "Jarma";
            //            break;
            //        case "22":
            //            s.UC = "Lachi (Rural)";
            //            break;
            //        case "23":
            //            s.UC = "Lachi (Urban)";
            //            break;
            //        case "24":
            //            s.UC = "Mandoori";
            //            break;
            //        case "25":
            //            s.UC = "Shah Pur";
            //            break;
            //        case "26":
            //            s.UC = "Shakardara Rural-I";
            //            break;
            //        case "27":
            //            s.UC = "Shakardara Rural-II";
            //            break;
            //        case "28":
            //            s.UC = "Shakardara Urban";
            //            break;
            //        case "29":
            //            s.UC = "Sudal";
            //            break;
            //        case "30":
            //            s.UC = "Summari";
            //            break;
            //        case "31":
            //            s.UC = "Surgul";
            //            break;
            //        case "32":
            //            s.UC = "Ali Zai";
            //            break;
            //        case "33":
            //            s.UC = "Bahadar Kot";
            //            break;
            //        case "34":
            //            s.UC = "Bilitang";
            //            break;
            //        case "35":
            //            s.UC = "Chorlaki";
            //            break;
            //        case "36":
            //            s.UC = "Dhoda";
            //            break;
            //        case "37":
            //            s.UC = "Gumbat";
            //            break;
            //        case "38":
            //            s.UC = "Kharmatoo";
            //            break;
            //        case "39":
            //            s.UC = "Khushal Garh";
            //            break;
            //        case "40":
            //            s.UC = "Kohat Urban-I";
            //            break;
            //        case "41":
            //            s.UC = "Kohat Urban-II";
            //            break;
            //        case "42":
            //            s.UC = "Kohat Urban-III";
            //            break;
            //        case "43":
            //            s.UC = "Kohat Urban-IV";
            //            break;
            //        case "44":
            //            s.UC = "Kohat Urban-V";
            //            break;
            //        case "45":
            //            s.UC = "Kohat Urban-VI";
            //            break;
            //        case "46":
            //            s.UC = "Muhammadzai";
            //            break;
            //        case "47":
            //            s.UC = "Nusrat Khel";
            //            break;
            //        case "48":
            //            s.UC = "Sher Kot";
            //            break;
            //        case "49":
            //            s.UC = "Togh Bala-I";
            //            break;
            //        case "50":
            //            s.UC = "Togh Bala-II";
            //            break;
            //        case "51":
            //            s.UC = "Usterzai";
            //            break;
            //        case "52":
            //            s.UC = "Ziarat Sheikh Allabad";
            //            break;
            //        case "53":
            //            s.UC = "Khalsa-I";
            //            break;
            //        case "54":
            //            s.UC = "Khalsa-II";
            //            break;
            //        case "55":
            //            s.UC = "Lahori";
            //            break;
            //        case "56":
            //            s.UC = "Mahal Terai-I";
            //            break;
            //        case "57":
            //            s.UC = "Mahal Terai-II";
            //            break;
            //        case "58":
            //            s.UC = "Shaheen Muslim Town-I";
            //            break;
            //        case "59":
            //            s.UC = "Karimpura";
            //            break;
            //        case "60":
            //            s.UC = "Shaheen Muslim Town-II";
            //            break;
            //        case "61":
            //            s.UC = "Shahi Bagh";
            //            break;
            //        case "62":
            //            s.UC = "Sheikh Junaid Abad";
            //            break;
            //        case "63":
            //            s.UC = "Akhun Abad";
            //            break;
            //        case "64":
            //            s.UC = "Andher Shehar";
            //            break;
            //        case "65":
            //            s.UC = "Asia";
            //            break;
            //        case "66":
            //            s.UC = "Bana Mari";
            //            break;
            //        case "67":
            //            s.UC = "Faqir Abad";
            //            break;
            //        case "68":
            //            s.UC = "Gul Bahar";
            //            break;
            //        case "69":
            //            s.UC = "Gunj";
            //            break;
            //        case "70":
            //            s.UC = "Jehangira Pura";
            //            break;
            //        case "71":
            //            s.UC = "Kakshal-I";
            //            break;
            //        case "72":
            //            s.UC = "Kakshal-II";
            //            break;
            //        case "73":
            //            s.UC = "Sikandar Town";
            //            break;
            //        case "74":
            //            s.UC = "Wazir Bagh";
            //            break;
            //        case "75":
            //            s.UC = "Yakatoot-I";
            //            break;
            //        case "76":
            //            s.UC = "Yakatoot-II";
            //            break;
            //        case "77":
            //            s.UC = "Yakatoot-III";
            //            break;
            //        case "78":
            //            s.UC = "Shahi Bagh";
            //            break;
            //        case "79":
            //            s.UC = "Sheikh Junaid Abad";
            //            break;
            //        case "80":
            //            s.UC = "Sikandar Town";
            //            break;
            //        case "81":
            //            s.UC = "Wazir Bagh";
            //            break;
            //        case "82":
            //            s.UC = "Yakatoot-I";
            //            break;
            //        case "83":
            //            s.UC = "Yakatoot-II";
            //            break;
            //        case "84":
            //            s.UC = "Yakatoot-III";
            //            break;
            //        case "85":
            //            s.UC = "Bhudhni";
            //            break;
            //        case "86":
            //            s.UC = "Chaghar Matti";
            //            break;
            //        case "87":
            //            s.UC = "Chamkani";
            //            break;
            //        case "88":
            //            s.UC = "Dag";
            //            break;
            //        case "89":
            //            s.UC = "Ghari Sherdad";
            //            break;
            //        case "90":
            //            s.UC = "Gulbela";
            //            break;
            //        case "91":
            //            s.UC = "Hassan Ghari-I";
            //            break;
            //        case "92":
            //            s.UC = "Hassan Ghari-II";
            //            break;
            //        case "93":
            //            s.UC = "Hayana Payan";
            //            break;
            //        case "94":
            //            s.UC = "Jogani";
            //            break;
            //        case "95":
            //            s.UC = "Kafoor Dheri";
            //            break;
            //        case "96":
            //            s.UC = "Kaniza";
            //            break;
            //        case "97":
            //            s.UC = "Kankola";
            //            break;
            //        case "98":
            //            s.UC = "Khazana";
            //            break;
            //        case "99":
            //            s.UC = "Lala";
            //            break;
            //        case "100":
            //            s.UC = "Larama";
            //            break;
            //        case "101":
            //            s.UC = "Mathra";
            //            break;
            //        case "102":
            //            s.UC = "Nahqi";
            //            break;
            //        case "103":
            //            s.UC = "Pajjagi";
            //            break;
            //        case "104":
            //            s.UC = "Pakha Ghulam";
            //            break;
            //        case "105":
            //            s.UC = "Panam Dheri";
            //            break;
            //        case "106":
            //            s.UC = "Shahi Bala";
            //            break;
            //        case "107":
            //            s.UC = "Takhtabad";
            //            break;
            //        case "108":
            //            s.UC = "Wadpagga";
            //            break;
            //        case "109":
            //            s.UC = "Achini Bala";
            //            break;
            //        case "110":
            //            s.UC = "Bazid Khel";
            //            break;
            //        case "111":
            //            s.UC = "Deh Bahadar";
            //            break;
            //        case "112":
            //            s.UC = "Dheri Baghbanan";
            //            break;
            //        case "113":
            //            s.UC = "Hayatabad-I";
            //            break;
            //        case "114":
            //            s.UC = "Hayatabad-II";
            //            break;
            //        case "115":
            //            s.UC = "Landi Arbab";
            //            break;
            //        case "116":
            //            s.UC = "Malkandheri";
            //            break;
            //        case "117":
            //            s.UC = "Nothia";
            //            break;
            //        case "118":
            //            s.UC = "Nothia Jadeed";
            //            break;
            //        case "119":
            //            s.UC = "Palosi";
            //            break;
            //        case "120":
            //            s.UC = "Pawaka";
            //            break;
            //        case "121":
            //            s.UC = "Pishtakhara Payan";
            //            break;
            //        case "122":
            //            s.UC = "Regi";
            //            break;
            //        case "123":
            //            s.UC = "Sarband";
            //            break;
            //        case "124":
            //            s.UC = "Shaheen Town";
            //            break;
            //        case "125":
            //            s.UC = "Sufaid Dheri";
            //            break;
            //        case "126":
            //            s.UC = "Tehkal Bala";
            //            break;
            //        case "127":
            //            s.UC = "Tehkal Payan-I";
            //            break;
            //        case "128":
            //            s.UC = "Tehkal Payan-II";
            //            break;
            //        case "129":
            //            s.UC = "University Town";
            //            break;
            //        case "130":
            //            s.UC = "Adezai";
            //            break;
            //        case "131":
            //            s.UC = "Aza Khel";
            //            break;
            //        case "132":
            //            s.UC = "Badabare Harizai";
            //            break;
            //        case "133":
            //            s.UC = "Badabare Maryamzai";
            //            break;
            //        case "134":
            //            s.UC = "Hazar Khwani-I";
            //            break;
            //        case "135":
            //            s.UC = "Hazar Khwani-II";
            //            break;
            //        case "136":
            //            s.UC = "Maira Kachori";
            //            break;
            //        case "137":
            //            s.UC = "Maira Surizai Payan";
            //            break;
            //        case "138":
            //            s.UC = "Maryamzai";
            //            break;
            //        case "139":
            //            s.UC = "Mashoogagar";
            //            break;
            //        case "140":
            //            s.UC = "Mathani";
            //            break;
            //        case "141":
            //            s.UC = "Musazai";
            //            break;
            //        case "142":
            //            s.UC = "Sheikh Muhammadii";
            //            break;
            //        case "143":
            //            s.UC = "Sheikhan";
            //            break;
            //        case "144":
            //            s.UC = "Shirkira";
            //            break;
            //        case "145":
            //            s.UC = "Suleman Khel";
            //            break;
            //        case "146":
            //            s.UC = "Surizai Bala";
            //            break;
            //        case "147":
            //            s.UC = "Surizai Payan";
            //            break;
            //        case "148":
            //            s.UC = "Urmar Bala";
            //            break;
            //        case "149":
            //            s.UC = "Urmar Miana";
            //            break;
            //        case "150":
            //            s.UC = "Urmar Payan";
            //            break;
            //        case "151":
            //            s.UC = "Adamzai";
            //            break;
            //        case "152":
            //            s.UC = "Akora Khattak M.c";
            //            break;
            //        case "153":
            //            s.UC = "Azakhel Bala";
            //            break;
            //        case "154":
            //            s.UC = "Badrashi";
            //            break;
            //        case "155":
            //            s.UC = "Dheri Katti Khel";
            //            break;
            //        case "156":
            //            s.UC = "Gandiri";
            //            break;
            //        case "157":
            //            s.UC = "Inzari";
            //            break;
            //        case "158":
            //            s.UC = "Kahi";
            //            break;
            //        case "159":
            //            s.UC = "Khairabad";
            //            break;
            //        case "160":
            //            s.UC = "Khaishki Bala";
            //            break;
            //        case "161":
            //            s.UC = "Khaishki Payan";
            //            break;
            //        case "162":
            //            s.UC = "Pabbi";
            //            break;
            //        case "163":
            //            s.UC = "Jehangira-I";
            //            break;
            //        case "164":
            //            s.UC = "Mandori";
            //            break;
            //        case "165":
            //            s.UC = "Manki Sharif";
            //            break;
            //        case "166":
            //            s.UC = "Maira Akora Khattak";
            //            break;
            //        case "167":
            //            s.UC = "Misri Banda";
            //            break;
            //        case "168":
            //            s.UC = "Mohib Banda";
            //            break;
            //        case "169":
            //            s.UC = "Mughalki";
            //            break;
            //        case "170":
            //            s.UC = "Nizampur";
            //            break;
            //        case "171":
            //            s.UC = "Nowshera City";
            //            break;
            //        case "172":
            //            s.UC = "Nowshera Kalan";
            //            break;
            //        case "173":
            //            s.UC = "Nowshera Cantt";
            //            break;
            //        case "174":
            //            s.UC = "Pahari Kati Khel";
            //            break;
            //        case "175":
            //            s.UC = "Pir Piai";
            //            break;
            //        case "176":
            //            s.UC = "Pir Sabak";
            //            break;
            //        case "177":
            //            s.UC = "Rashakai";
            //            break;
            //        case "178":
            //            s.UC = "Risalpur";
            //            break;
            //        case "179":
            //            s.UC = "Saleh Khana";
            //            break;
            //        case "180":
            //            s.UC = "Shaidu";
            //            break;
            //        case "181":
            //            s.UC = "Aman Garh";
            //            break;
            //        case "182":
            //            s.UC = "Tarkha";
            //            break;
            //        case "183":
            //            s.UC = "Jalozai";
            //            break;
            //        case "184":
            //            s.UC = "Ziarat Kaka Sahib";
            //            break;
            //        case "185":
            //            s.UC = "Chowkai Town";
            //            break;
            //        case "186":
            //            s.UC = "Azakhel Payan";
            //            break;
            //        case "187":
            //            s.UC = "Bara Banda";
            //            break;
            //        case "188":
            //            s.UC = "Kabul River";
            //            break;
            //        case "189":
            //            s.UC = "Nawan Killi";
            //            break;
            //        case "190":
            //            s.UC = "Zara Miana";
            //            break;
            //        case "191":
            //            s.UC = "Akbar Pura";
            //            break;
            //        case "192":
            //            s.UC = "Aman Kot";
            //            break;
            //        case "193":
            //            s.UC = "Chowkai Mamraiz";
            //            break;
            //        case "194":
            //            s.UC = "Dag Behsud";
            //            break;
            //        case "195":
            //            s.UC = "Dag Ismail Khel";
            //            break;
            //        case "196":
            //            s.UC = "Shah Kot";
            //            break;
            //        case "197":
            //            s.UC = "Taru Jabba";
            //            break;
            //        case "198":
            //            s.UC = "Daggai";
            //            break;
            //        case "199":
            //            s.UC = "Dag Ismail Khel Chapri";
            //            break;
            //        default:
            //            s.UC = "";
            //            break;
            //    }
            //    switch (s.DS1)
            //    {
            //        case "a":
            //            s.DS1 = "Stay here in this UC";
            //            break;
            //        case "b":
            //            s.DS1 = "Move to another UC";
            //            break;
            //        default:
            //            s.DS1 = "";
            //            break;
            //    }

            //    //sync logic for P4
            //    if (s.P4.Contains("a"))
            //    {
            //        s.P4a = "Feeling of being safe";
            //    }
            //    if (s.P4.Contains("b"))
            //    {
            //        s.P4b = "Affordable rent";
            //    }
            //    if (s.P4.Contains("c"))
            //    {
            //        s.P4c = "Availability of jobs";
            //    }
            //    if (s.P4.Contains("d"))
            //    {
            //        s.P4d = "Access to assistance";
            //    }
            //    if (s.P4.Contains("e"))
            //    {
            //        s.P4e = "Access to basic services";
            //    }
            //    if (s.P4.Contains("f"))
            //    {
            //        s.P4f = "Others";
            //    }

            //    //Sync P1a
            //    if (s.P1a.Contains("a"))
            //    {
            //        s.P1a1 = "Food";
            //    }
            //    if (s.P1a.Contains("b"))
            //    {
            //        s.P1a2 = "Cash Assistance";
            //    }
            //    if (s.P1a.Contains("c"))
            //    {
            //        s.P1a3 = "Shelter Assistance";
            //    }
            //    if (s.P1a.Contains("d"))
            //    {
            //        s.P1a4 = "Non Food Items";
            //    }
            //    if (s.P1a.Contains("e"))
            //    {
            //        s.P1a5 = "Other";
            //    }

            //    //Sync P1b
            //    if (s.P1b.Contains("a"))
            //    {
            //        s.P1b1 = "Civil Authorities";
            //    }
            //    if (s.P1b.Contains("b"))
            //    {
            //        s.P1b2 = "Military";
            //    }
            //    if (s.P1b.Contains("c"))
            //    {
            //        s.P1b3 = "NGOs";
            //    }
            //    if (s.P1b.Contains("d"))
            //    {
            //        s.P1b4 = "UN";
            //    }
            //    if (s.P1b.Contains("e"))
            //    {
            //        s.P1b5 = "Other";
            //    }

            //    //SyncP2a
            //    if (s.P2a.Contains("a"))
            //    {
            //        s.P2a1 = "Theft and Robbery";
            //    }
            //    if (s.P2a.Contains("b"))
            //    {
            //        s.P2a2 = "Killing";
            //    }
            //    if (s.P2a.Contains("c"))
            //    {
            //        s.P2a3 = "Injury/Physical Assault";
            //    }
            //    if (s.P2a.Contains("d"))
            //    {
            //        s.P2a4 = "Threat/harassment by host communities";
            //    }
            //    if (s.P2a.Contains("e"))
            //    {
            //        s.P2a5 = "Threat/harrassment by authorities";
            //    }
            //    if (s.P2a.Contains("f"))
            //    {
            //        s.P2a6 = "Threat/harrassment by armed groups";
            //    }
            //    if (s.P2a.Contains("g"))
            //    {
            //        s.P2a7 = "Violence against boys/girls";
            //    }
            //    if (s.P2a.Contains("h"))
            //    {
            //        s.P2a8 = "Gender based violence";
            //    }
            //    if (s.P2a.Contains("i"))
            //    {
            //        s.P2a9 = "Kidnapping and abductions";
            //    }
            //    if (s.P2a.Contains("j"))
            //    {
            //        s.P2a10 = "Other";
            //    }

            //    //Sync P5
            //    if (s.P5.Contains("a"))
            //    {
            //        s.P5a = "Children";
            //    }
            //    if (s.P5.Contains("b"))
            //    {
            //        s.P5b = "Women";
            //    }
            //    if (s.P5.Contains("c"))
            //    {
            //        s.P5c = "Men";
            //    }
            //    if (s.P5.Contains("d"))
            //    {
            //        s.P5d = "Elderly";
            //    }
            //    if (s.P5.Contains("e"))
            //    {
            //        s.P5e = "Disabled";
            //    }
            //    if (s.P5.Contains("f")) //was  a
            //    {
            //        s.P5f = "None";
            //    }

            //    //Sync P7
            //    if (s.P7.Contains("a"))
            //    {
            //        s.P7a = "Mobility aids";
            //    }
            //    if (s.P7.Contains("b"))
            //    {
            //        s.P7b = "Hearing aids";
            //    }
            //    if (s.P7.Contains("c"))
            //    {
            //        s.P7c = "Visual aids";
            //    }
            //    if (s.P7.Contains("d"))
            //    {
            //        s.P7d = "Medical services";
            //    }
            //    if (s.P7.Contains("e"))
            //    {
            //        s.P7e = "Others";
            //    }
            //    if (s.P7.Contains("f"))
            //    {
            //        s.P7f = "None";
            //    }
            //    //Sync W1
            //    if (s.W1.Contains("a"))
            //    {
            //        s.W1a = "Surface Water";
            //    }
            //    if (s.W1.Contains("b"))
            //    {
            //        s.W1b = "Protected well/spring";
            //    }
            //    if (s.W1.Contains("c"))
            //    {
            //        s.W1c = "Unprotected well/spring";
            //    }
            //    if (s.W1.Contains("d"))
            //    {
            //        s.W1d = "Unprotected handpumps";
            //    }
            //    if (s.W1.Contains("e"))
            //    {
            //        s.W1e = "Protected handpumps";
            //    }
            //    if (s.W1.Contains("f"))
            //    {
            //        s.W1f = "Piped water supply";
            //    }
            //    if (s.W1.Contains("g"))
            //    {
            //        s.W1g = "Tanker";
            //    }
            //    if (s.W1.Contains("h"))
            //    {
            //        s.W1h = "Other";
            //    }
            //    if (s.W1.Contains("i"))
            //    {
            //        s.W1i = "Dont know";        //Dont know without comma
            //    }

            //    //Sync W2
            //    if (s.W2.Contains("a"))
            //    {
            //        s.W2a = "Chlorination";
            //    }
            //    if (s.W2.Contains("b"))
            //    {
            //        s.W2b = "Boiling";
            //    }
            //    if (s.W2.Contains("c"))
            //    {
            //        s.W2c = "Filter and Stand";
            //    }
            //    if (s.W2.Contains("d"))
            //    {
            //        s.W2d = "Solar";
            //    }
            //    if (s.W2.Contains("e"))
            //    {
            //        s.W2e = "Other";
            //    }
            //    if (s.W2.Contains("f"))
            //    {
            //        s.W2f = "None";
            //    }

            //    //Sync W3
            //    if (s.W3.Contains("a"))
            //    {
            //        s.W3a = "Open vessel";
            //    }
            //    if (s.W3.Contains("b"))
            //    {
            //        s.W3b = "closed vessel";
            //    }
            //    if (s.W3.Contains("c"))
            //    {
            //        s.W3c = "Jerry can";
            //    }
            //    if (s.W3.Contains("d"))
            //    {
            //        s.W3d = "Ceramic pot";
            //    }
            //    if (s.W3.Contains("e"))
            //    {
            //        s.W3e = "Dirty vessel";
            //    }


            //    //Sync L5
            //    if (s.L5.Contains("a"))
            //    {
            //        s.L5a = "Feeds";
            //    }
            //    if (s.L5.Contains("b"))
            //    {
            //        s.L5b = "Medication";
            //    }
            //    if (s.L5.Contains("c"))
            //    {
            //        s.L5c = "Shelter";
            //    }
            //    if (s.L5.Contains("d"))
            //    {
            //        s.L5d = "Milking kits"; //fixed
            //    }
            //    if (s.L5.Contains("e"))
            //    {
            //        s.L5e = "None";     //fixed
            //    }


            //    //Sync L6
            //    if (s.L6.Contains("a"))
            //    {
            //        s.L6a = "Borrow food, or rely on help from friends";
            //    }
            //    if (s.L6.Contains("b"))
            //    {
            //        s.L6b = "Eat less preferred or cheaper food";
            //    }
            //    if (s.L6.Contains("c"))
            //    {
            //        s.L6c = "Purchase food on debts";
            //    }
            //    if (s.L6.Contains("d"))
            //    {
            //        s.L6d = "Limit portion size at meals";
            //    }
            //    if (s.L6.Contains("e"))
            //    {
            //        s.L6e = "Selling  household items/ jewelleries";
            //    }
            //    if (s.L6.Contains("f"))
            //    {
            //        s.L6f = "Decrease expenses on health care";
            //    }
            //    if (s.L6.Contains("g"))
            //    {
            //        s.L6g = "Skipped entire day's meal";
            //    }
            //    if (s.L6.Contains("h"))
            //    {
            //        s.L6h = "Women ate less food than men";
            //    }
            //    if (s.L6.Contains("i"))
            //    {
            //        s.L6i = "Adults eat less in order to provide food for children";
            //    }
            //    if (s.L6.Contains("j"))
            //    {
            //        s.L6j = "Send children to work";
            //    }
            //    if (s.L6.Contains("k"))
            //    {
            //        s.L6k = "Sent family members to work abroad";
            //    }
            //    if (s.L6.Contains("l"))
            //    {
            //        s.L6l = "Selling livestock";
            //    }
            //    if (s.L6.Contains("m"))
            //    {
            //        s.L6m = "Other";
            //    }
            //    if (s.L6.Contains("n"))
            //    {
            //        s.L6n = "None of these";
            //    }


            //    //Sync E3
            //    if (s.E3.Contains("a"))
            //    {
            //        s.E3a = "Unavailability of schools";
            //    }
            //    if (s.E3.Contains("b"))
            //    {
            //        s.E3b = "Not able to sit in exams";
            //    }
            //    if (s.E3.Contains("c"))
            //    {
            //        s.E3c = "Lack of documentation";
            //    }
            //    if (s.E3.Contains("d"))
            //    {
            //        s.E3d = "Lack of uniform/books";
            //    }
            //    if (s.E3.Contains("e"))
            //    {
            //        s.E3e = "Lack of fees";
            //    }
            //    if (s.E3.Contains("f"))
            //    {
            //        s.E3f = "Cultural constraints";
            //    }
            //    if (s.E3.Contains("g"))
            //    {
            //        s.E3g = "Other";
            //    }

            //    //Sync N1
            //    switch (s.N1)
            //    {
            //        case "a":
            //            s.N1 = "More women breast-feeding";
            //            break;
            //        case "b":
            //            s.N1 = "Less women breast feeding";
            //            break;
            //        case "c":
            //            s.N1 = "No change, the same number are breast-feeding";
            //            break;
            //        case "d":
            //            s.N1 = "Dont know";
            //            break;

            //        default:
            //            s.N1 = "";
            //            break;

            //    }
            //    //Sync N2
            //    if (s.N2.Contains("a"))
            //    {
            //        s.N2a = "Lack of privacy / space";
            //    }
            //    if (s.N2.Contains("b"))
            //    {
            //        s.N2b = "No/Less Breast milk (perhaps due to stress or poor health)";
            //    }
            //    if (s.N2.Contains("c"))
            //    {
            //        s.N2c = "Other";
            //    }

            //    //Sync N3
            //    if (s.N3.Contains("a"))
            //    {
            //        s.N3a = "Breast-feeding stopped";
            //    }
            //    if (s.N3.Contains("b"))
            //    {
            //        s.N3b = "Breast-feeding reduced";
            //    }
            //    if (s.N3.Contains("c"))
            //    {
            //        s.N3c = "Complementary feeding quantity increased";
            //    }
            //    if (s.N3.Contains("d"))
            //    {
            //        s.N3d = "Complementary feeding quantity decreased";
            //    }
            //    if (s.N3.Contains("e"))
            //    {
            //        s.N3e = "Other";
            //    }
            //    if (s.N3.Contains("f"))
            //    {
            //        s.N3f = "No change";
            //    }

            //    //Sync N5 
            //    if (s.N5.Contains("a"))
            //    {
            //        s.N5a = "Diarrhea";
            //    }
            //    if (s.N5.Contains("b"))
            //    {
            //        s.N5b = "Cough/cold";
            //    }
            //    if (s.N5.Contains("c"))
            //    {
            //        s.N5c = "Gastro/Diarrhea";
            //    }
            //    if (s.N5.Contains("d"))
            //    {
            //        s.N5d = "Mental/trauma";
            //    }
            //    if (s.N5.Contains("e"))
            //    {
            //        s.N5e = "Injury";
            //    }
            //    if (s.N5.Contains("f"))
            //    {
            //        s.N5f = "Skin/infections";
            //    }
            //    if (s.N5.Contains("g"))
            //    {
            //        s.N5g = "Fever";
            //    }
            //    if (s.N5.Contains("h"))
            //    {
            //        s.N5h = "Pregnancy/problems";
            //    }
            //    if (s.N5.Contains("i"))
            //    {
            //        s.N5i = "Measles";
            //    }
            //    if (s.N5.Contains("j"))
            //    {
            //        s.N5j = "Other";
            //    }
            //    if (s.N5.Contains("k"))
            //    {
            //        s.N5k = "None";
            //    }

            //    //Sync N6a
            //    if (s.N6a.Contains("a"))
            //    {
            //        s.N6a1 = "Basic Health Unit";
            //    }
            //    if (s.N6a.Contains("b"))
            //    {
            //        s.N6a2 = "Rural Health Centre";
            //    }
            //    if (s.N6a.Contains("c"))
            //    {
            //        s.N6a3 = "Private Health Care Provider";
            //    }
            //    if (s.N6a.Contains("d"))
            //    {
            //        s.N6a4 = "Traditional Healer";
            //    }
            //    if (s.N6a.Contains("e"))
            //    {
            //        s.N6a5 = "Someone in family";
            //    }
            //    if (s.N6a.Contains("f"))
            //    {
            //        s.N6a6 = "No where";
            //    }
            //    if (s.N6a.Contains("g"))
            //    {
            //        s.N6a7 = "Dont know";
            //    }

            //    //Sync N6b
            //    if (s.N6b.Contains("a"))
            //    {
            //        s.N6b1 = "Distance";
            //    }
            //    if (s.N6b.Contains("b"))
            //    {
            //        s.N6b2 = "Cost";
            //    }
            //    if (s.N6b.Contains("c"))
            //    {
            //        s.N6b3 = " Lack of transport";
            //    }
            //    if (s.N6b.Contains("d"))
            //    {
            //        s.N6b4 = "Lack of medicine";
            //    }
            //    if (s.N6b.Contains("e"))
            //    {
            //        s.N6b5 = " Lack of access of elderly/ disabled";
            //    }
            //    if (s.N6b.Contains("f"))
            //    {
            //        s.N6b6 = "Cultural restrictions";
            //    }
            //    if (s.N6b.Contains("g"))
            //    {
            //        s.N6b7 = "Security";
            //    }
            //    if (s.N6b.Contains("h"))
            //    {
            //        s.N6b8 = "Other";
            //    }

            //    //Sync N7
            //    if (s.N7.Contains("a"))
            //    {
            //        s.N7a = "Free medicines";
            //    }
            //    if (s.N7.Contains("b"))
            //    {
            //        s.N7b = "Antenatal services";
            //    }
            //    if (s.N7.Contains("c"))
            //    {
            //        s.N7c = "Delivery services";
            //    }
            //    if (s.N7.Contains("d"))
            //    {
            //        s.N7d = "Family planning services";
            //    }
            //    if (s.N7.Contains("e"))
            //    {
            //        s.N7e = "Ambulance services";
            //    }
            //    if (s.N7.Contains("f"))
            //    {
            //        s.N7f = "Vaccination services";
            //    }
            //    if (s.N7.Contains("g"))
            //    {
            //        s.N7g = "Basic Laboratory services";
            //    }
            //    if (s.N7.Contains("h"))
            //    {
            //        s.N7h = "Mental health/psycho-social support";
            //    }
            //    if (s.N7.Contains("i"))
            //    {
            //        s.N7i = "Dont know";
            //    }
            //    if (s.N7.Contains("j"))
            //    {
            //        s.N7j = "Other";
            //    }
            //    if (s.N7.Contains("k"))
            //    {
            //        s.N7k = "None";
            //    }

            //    //Sync S3
            //    if (s.S3.Contains("a"))
            //    {
            //        s.S3a = "Open Air";
            //    }
            //    if (s.S3.Contains("b"))
            //    {
            //        s.S3b = "Shared room with other families";
            //    }
            //    if (s.S3.Contains("c"))
            //    {
            //        s.S3c = "Own Room";
            //    }
            //    if (s.S3.Contains("d"))
            //    {
            //        s.S3d = "More than one room";
            //    }

            //    //Sync S11
            //    if (s.S11.Contains("Food"))
            //    {
            //        s.S11a = "Food";
            //    }
            //    if (s.S11.Contains("Space"))
            //    {
            //        s.S11b = "Space";
            //    }
            //    if (s.S11.Contains("Wash"))
            //    {
            //        s.S11c = "Wash";
            //    }
            //    if (s.S11.Contains("Cash"))
            //    {
            //        s.S11d = "Cash";
            //    }
            //    if (s.S11.Contains("Other"))
            //    {
            //        s.S11e = "Other";
            //    }
            //    synced.Add(s);
            //}

            return synced;
        }
    }
}
