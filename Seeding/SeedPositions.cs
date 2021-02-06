using sp19team18finalproject.Models;
using sp19team18finalproject.DAL;
using System.Collections.Generic;
using System;
using System.Linq;

namespace sp19team18finalproject.Seeding
{
    public static class SeedPositions
    {
        public static void SeedAllPositions(AppDbContext db)
        {
            //if (db.AppUsers.Count() == 51)
            //{
             //   throw new NotSupportedException("The database already contains all 51 AppUsers!");
            //}

            Int32 intPositionsAdded = 0;
            Int32 intMajorPositionsAdded = 0;
            String strPositionTitle = "Begin"; //helps to keep track of error on books
            Int32 idMajorPosition = 0; //helps to keep track of error on books
            List<Position> Positions = new List<Position>();
            List<MajorPosition> MajorPositions = new List<MajorPosition>();

            try
            {
                Position p1 = new Position() { PositionTitle = "Supply Chain Internship", PositionType = "I", Location = "Houston, Texas", Deadline = new DateTime(2019,5,5) };
                p1.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Shell");
                Positions.Add(p1);

                MajorPosition mp1 = new MajorPosition();
                mp1.Position = p1;
                mp1.Major = db.Majors.FirstOrDefault(m => m.MajorName == "Supply Chain Management");
                MajorPositions.Add(mp1);


                Position p2 = new Position() { PositionTitle = "Accounting Intern", PositionType = "I", Location = "Austin, Texas", Deadline = new DateTime(2019, 5, 1), Description = "Work in our audit group" };
                p2.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Deloitte");
                Positions.Add(p2);

                MajorPosition mp2 = new MajorPosition();
                mp2.Position = p2;
                mp2.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Accounting");
                MajorPositions.Add(mp2);



                Position p3 = new Position() { PositionTitle = "Web Development", PositionType = "FT", Location = "Richmond, Virginia", Deadline = new DateTime(2019, 3, 14), Description = "Developing a great new website for customer portfolio management" };
                p3.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Capital One");
                Positions.Add(p3);

                MajorPosition mp3 = new MajorPosition();
                mp3.Position = p3;
                mp3.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp3);



                Position p4 = new Position() { PositionTitle = "Sales Associate", PositionType = "FT", Location = "Los Angeles, California", Deadline = new DateTime(2019, 4, 1) };
                p4.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Aon");
                Positions.Add(p4);

                MajorPosition mp4 = new MajorPosition();
                mp4.Position = p4;
                mp4.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Accounting");
                MajorPositions.Add(mp4);

                MajorPosition mp5 = new MajorPosition();
                mp5.Position = p4;
                mp5.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Marketing");
                MajorPositions.Add(mp5);

                MajorPosition mp6 = new MajorPosition();
                mp6.Position = p4;
                mp6.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Finance");
                MajorPositions.Add(mp6);




                Position p5 = new Position() { PositionTitle = "Amenities Analytics Intern", PositionType = "I", Location = "New York, New York", Deadline = new DateTime(2019, 3, 30), Description = "Help analyze our amenities and customer rewards programs" };
                p5.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Hilton Worldwide");
                Positions.Add(p5);

                MajorPosition mp7 = new MajorPosition();
                mp7.Position = p5;
                mp7.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Finance");
                MajorPositions.Add(mp7);

                MajorPosition mp8 = new MajorPosition();
                mp8.Position = p5;
                mp8.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp8);

                MajorPosition mp9 = new MajorPosition();
                mp9.Position = p5;
                mp9.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Marketing");
                MajorPositions.Add(mp9);

                MajorPosition mp10 = new MajorPosition();
                mp10.Position = p5;
                mp10.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Business Honors");
                MajorPositions.Add(mp10);




                Position p6 = new Position() { PositionTitle = "Junior Programmer", PositionType = "I", Location = "Redmond, Washington", Deadline = new DateTime(2019, 4, 3) };
                p6.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Microsoft");
                Positions.Add(p6);

                MajorPosition mp11 = new MajorPosition();
                mp11.Position = p6;
                mp11.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp11);




                Position p7 = new Position() { PositionTitle = "Consultant ", PositionType = "FT", Location = "Houston, Texas", Deadline = new DateTime(2019, 4, 15), Description = "Full-time consultant position"};
                p7.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Accenture");
                Positions.Add(p7);

                MajorPosition mp12 = new MajorPosition();
                mp12.Position = p7;
                mp12.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp12);

                MajorPosition mp13 = new MajorPosition();
                mp13.Position = p7;
                mp13.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Accounting");
                MajorPositions.Add(mp13);

                MajorPosition mp14 = new MajorPosition();
                mp14.Position = p7;
                mp14.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Business Honors");
                MajorPositions.Add(mp14);




                Position p8 = new Position() { PositionTitle = "Project Manager", PositionType = "FT", Location = "Chicago, Illinois", Deadline = new DateTime(2019, 6, 1) };
                p8.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Aon");
                Positions.Add(p8);

                MajorPosition mp15 = new MajorPosition();
                mp15.Position = p8;
                mp15.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp15);

                MajorPosition mp16 = new MajorPosition();
                mp16.Position = p8;
                mp16.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Supply Chain Management");
                MajorPositions.Add(mp16);

                MajorPosition mp17 = new MajorPosition();
                mp17.Position = p8;
                mp17.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Accounting");
                MajorPositions.Add(mp17);

                MajorPosition mp18 = new MajorPosition();
                mp18.Position = p8;
                mp18.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Marketing");
                MajorPositions.Add(mp18);

                MajorPosition mp19 = new MajorPosition();
                mp19.Position = p8;
                mp19.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Finance");
                MajorPositions.Add(mp19);

                MajorPosition mp20 = new MajorPosition();
                mp20.Position = p8;
                mp20.Major = db.Majors.FirstOrDefault(p => p.MajorName == "International Business");
                MajorPositions.Add(mp20);

                MajorPosition mp21 = new MajorPosition();
                mp21.Position = p8;
                mp21.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Business Honors ");
                MajorPositions.Add(mp21);



                Position p9 = new Position() { PositionTitle = "Account Manager", PositionType = "FT", Location = "Dallas, Texas", Deadline = new DateTime(2019, 2, 28) };
                p9.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Deloitte");
                Positions.Add(p9);

                MajorPosition mp22 = new MajorPosition();
                mp22.Position = p9;
                mp22.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Accounting");
                MajorPositions.Add(mp22);

                MajorPosition mp23 = new MajorPosition();
                mp23.Position = p9;
                mp23.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Business Honors");
                MajorPositions.Add(mp23);





                Position p10 = new Position() { PositionTitle = "Marketing Intern", PositionType = "I", Location = "Austin, Texas", Deadline = new DateTime(2019, 4, 30), Description = "Help our marketing team develop new advertising strategies for local Austin businesses" };
                p10.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Adlucent");
                Positions.Add(p10);

                MajorPosition mp24 = new MajorPosition();
                mp24.Position = p10;
                mp24.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Marketing");
                MajorPositions.Add(mp24);




                Position p11 = new Position() { PositionTitle = "Financial Analyst", PositionType = "FT", Location = "Richmond, Virginia", Deadline = new DateTime(2019, 4, 15) };
                p11.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Capital One");
                Positions.Add(p11);

                MajorPosition mp25 = new MajorPosition();
                mp25.Position = p11;
                mp25.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Finance");
                MajorPositions.Add(mp25);




                Position p12 = new Position() { PositionTitle = "Pilot", PositionType = "FT", Location = "Ft. Worth, Texas", Deadline = new DateTime(2019, 10, 8)};
                p12.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "United Airlines");
                Positions.Add(p12);

                MajorPosition mp26 = new MajorPosition();
                mp26.Position = p12;
                mp26.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp26);

                MajorPosition mp27 = new MajorPosition();
                mp27.Position = p12;
                mp27.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Supply Chain Management");
                MajorPositions.Add(mp27);

                MajorPosition mp28 = new MajorPosition();
                mp28.Position = p12;
                mp28.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Accounting");
                MajorPositions.Add(mp28);

                MajorPosition mp29 = new MajorPosition();
                mp29.Position = p12;
                mp29.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Marketing");
                MajorPositions.Add(mp29);


                MajorPosition mp30 = new MajorPosition();
                mp30.Position = p12;
                mp30.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Finance");
                MajorPositions.Add(mp30);


                MajorPosition mp31 = new MajorPosition();
                mp31.Position = p12;
                mp31.Major = db.Majors.FirstOrDefault(p => p.MajorName == "International Business");
                MajorPositions.Add(mp31);


                MajorPosition mp32 = new MajorPosition();
                mp32.Position = p12;
                mp32.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Business Honors");
                MajorPositions.Add(mp32);





                Position p13 = new Position() { PositionTitle = "Corporate Recruiting Intern", PositionType = "I", Location = "Redmond, Washington", Deadline = new DateTime(2019, 4, 30)};
                p13.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Microsoft");
                Positions.Add(p13);

                MajorPosition mp33 = new MajorPosition();
                mp33.Position = p13;
                mp33.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Management");
                MajorPositions.Add(mp33);




                Position p14 = new Position() { PositionTitle = "Business Analyst", PositionType = "FT", Location = "Austin, Texas", Deadline = new DateTime(2019, 5, 31)};
                p14.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Microsoft");
                Positions.Add(p14);

                MajorPosition mp34 = new MajorPosition();
                mp34.Position = p14;
                mp34.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp34);




                Position p15 = new Position() { PositionTitle = "Programmer Analyst", PositionType = "FT", Location = "Minneapolis, Minnesota", Deadline = new DateTime(2019, 5, 15) };
                p15.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Target");
                Positions.Add(p15);

                MajorPosition mp35 = new MajorPosition();
                mp35.Position = p15;
                mp35.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp35);





                Position p16 = new Position() { PositionTitle = "Intern", PositionType = "I", Location = "Minneapolis, Minnesota", Deadline = new DateTime(2019, 5, 15) };
                p16.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Target");
                Positions.Add(p16);

                MajorPosition mp36 = new MajorPosition();
                mp36.Position = p16;
                mp36.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Supply Chain Management");
                MajorPositions.Add(mp36);

                MajorPosition mp37 = new MajorPosition();
                mp37.Position = p16;
                mp37.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Accounting");
                MajorPositions.Add(mp37);

                MajorPosition mp38 = new MajorPosition();
                mp38.Position = p16;
                mp38.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp38);

                MajorPosition mp39 = new MajorPosition();
                mp39.Position = p16;
                mp39.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Marketing");
                MajorPositions.Add(mp39);

                MajorPosition mp40 = new MajorPosition();
                mp40.Position = p16;
                mp40.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Finance");
                MajorPositions.Add(mp40);

                MajorPosition mp41 = new MajorPosition();
                mp41.Position = p16;
                mp41.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Business Honors");
                MajorPositions.Add(mp41);

                MajorPosition mp42 = new MajorPosition();
                mp42.Position = p16;
                mp42.Major = db.Majors.FirstOrDefault(p => p.MajorName == "International Business");
                MajorPositions.Add(mp42);

                MajorPosition mp43 = new MajorPosition();
                mp43.Position = p16;
                mp43.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Science and Technology Management");
                MajorPositions.Add(mp43);

                MajorPosition mp44 = new MajorPosition();
                mp44.Position = p16;
                mp44.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Management");
                MajorPositions.Add(mp44);



                
                Position p17 = new Position() { PositionTitle = "Digital Intern", PositionType = "I", Location = "Dallas, Texas", Deadline = new DateTime(2019, 5, 20) };
                p17.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Accenture");
                //p17.Major = db.Majors.FirstorDefault(p => p.MajorName == "MIS, Marketing");

                MajorPosition mp45 = new MajorPosition();
                mp45.Position = p17;
                mp45.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp45);

                MajorPosition mp46 = new MajorPosition();
                mp46.Position = p17;
                mp46.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Marketing");
                MajorPositions.Add(mp46);



                Position p18 = new Position() { PositionTitle = "Analyst Development Program", PositionType = "I", Location = "Plano, Texas", Deadline = new DateTime(2019, 5, 20)  };
                p18.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Capital One");
                //p18.Major = db.Majors.FirstorDefault(p => p.MajorName == "Finance, MIS, Business Honors");

                MajorPosition mp47 = new MajorPosition();
                mp47.Position = p18;
                mp47.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Finance");
                MajorPositions.Add(mp47);

                MajorPosition mp48 = new MajorPosition();
                mp48.Position = p18;
                mp48.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp48);

                MajorPosition mp49 = new MajorPosition();
                mp49.Position = p18;
                mp49.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Business Honors");
                MajorPositions.Add(mp49);



                Position p19 = new Position() { PositionTitle = "Procurements Associate", PositionType = "FT", Location = "Houston,  Texas", Deadline = new DateTime(2019, 5, 30), Description = "Handle procurement and vendor accounts", };
                p19.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Shell");
               // p19.Major = db.Majors.FirstorDefault(p => p.MajorName == "Supply Chain Management");

                MajorPosition mp50 = new MajorPosition();
                mp50.Position = p19;
                mp50.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Supply Chain Management");
                MajorPositions.Add(mp50);



                Position p20 = new Position() { PositionTitle = "IT Rotational Program", PositionType = "FT", Location = "Dallas, Texas", Deadline = new DateTime(2019, 5, 30)};
                p20.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Texas Instruments");
                //p20.Major = db.Majors.FirstorDefault(p => p.MajorName == "MIS");

                MajorPosition mp51 = new MajorPosition();
                mp51.Position = p20;
                mp51.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp51);



                Position p21 = new Position() { PositionTitle = "Sales Rotational Program", PositionType = "FT", Location = "Dallas, Texas", Deadline = new DateTime(2019, 5, 30) };
                p21.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Texas Instruments");
                //p21.Major = db.Majors.FirstorDefault(p => p.MajorName == "Marketing, Management, Finance, Accounting");

                MajorPosition mp52 = new MajorPosition();
                mp52.Position = p21;
                mp52.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Marketing");
                MajorPositions.Add(mp52);

                MajorPosition mp53 = new MajorPosition();
                mp53.Position = p21;
                mp53.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Management");
                MajorPositions.Add(mp53);

                MajorPosition mp54 = new MajorPosition();
                mp54.Position = p21;
                mp54.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Finance");
                MajorPositions.Add(mp54);

                MajorPosition mp55 = new MajorPosition();
                mp55.Position = p21;
                mp55.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Accounting");
                MajorPositions.Add(mp55);



                Position p22 = new Position() { PositionTitle = "Accounting Rotational Program", PositionType = "FT", Location = "Austin, Texas", Deadline = new DateTime(2019, 5, 30) };
                p22.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Texas Instruments");
                //p22.Major = db.Majors.FirstorDefault(p => p.MajorName == "Accounting");

                MajorPosition mp56 = new MajorPosition();
                mp56.Position = p22;
                mp56.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Accounting");
                MajorPositions.Add(mp56);



                Position p23 = new Position() { PositionTitle = "Financial Planning Intern", PositionType = "I", Location = "Orlando, Florida", Deadline = new DateTime(2019, 6, 1) };
                p23.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Academy Sports & Outdoors");
                //p23.Major = db.Majors.FirstorDefault(p => p.MajorName == "Finance, Accounting, Business Honors");

                MajorPosition mp57 = new MajorPosition();
                mp57.Position = p23;
                mp57.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Finance");
                MajorPositions.Add(mp57);

                MajorPosition mp58 = new MajorPosition();
                mp58.Position = p23;
                mp58.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Accounting");
                MajorPositions.Add(mp58);

                MajorPosition mp59 = new MajorPosition();
                mp59.Position = p23;
                mp59.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Business Honors");
                MajorPositions.Add(mp59);



                Position p24 = new Position() { PositionTitle = "Digital Product Manager", PositionType = "FT", Location = "Houston, Texas", Deadline = new DateTime(2019, 6, 1) };
                p24.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Academy Sports & Outdoors");
                //p24.Major = db.Majors.FirstorDefault(p => p.MajorName == "MIS, Marketing, Business Honors, Management");

                MajorPosition mp60 = new MajorPosition();
                mp60.Position = p24;
                mp60.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp60);

                MajorPosition mp61 = new MajorPosition();
                mp61.Position = p24;
                mp61.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Marketing");
                MajorPositions.Add(mp61);

                MajorPosition mp62 = new MajorPosition();
                mp62.Position = p24;
                mp62.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Business Honors");
                MajorPositions.Add(mp62);

                MajorPosition mp63 = new MajorPosition();
                mp63.Position = p24;
                mp63.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Management");
                MajorPositions.Add(mp63);



                Position p25 = new Position() { PositionTitle = "Product Marketing Intern", PositionType = "I", Location = "Redmond, Washington", Deadline = new DateTime(2019, 6, 1) };
                p25.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Microsoft");
               // p25.Major = db.Majors.FirstorDefault(p => p.MajorName == "Marketing, MIS");

                MajorPosition mp64 = new MajorPosition();
                mp64.Position = p25;
                mp64.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Marketing");
                MajorPositions.Add(mp64);

                MajorPosition mp65 = new MajorPosition();
                mp65.Position = p25;
                mp65.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp65);

                Position p26 = new Position() { PositionTitle = "Program Manager", PositionType = "FT", Location = "Redmond, Washington", Deadline = new DateTime(2019, 6, 1) };
                p26.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Microsoft");
                //p26.Major = db.Majors.FirstorDefault(p => p.MajorName == "Marketing, MIS");

                MajorPosition mp66 = new MajorPosition();
                mp66.Position = p26;
                mp66.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Marketing");
                MajorPositions.Add(mp66);

                MajorPosition mp67 = new MajorPosition();
                mp67.Position = p26;
                mp67.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp67);
                

            
                Position p27 = new Position() { PositionTitle = "Security Analyst", PositionType = "FT", Location = "Redmond, Washington", Deadline = new DateTime(2019, 6, 1) };
                p27.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "Microsoft");
                //p27.Major = db.Majors.FirstorDefault(p => p.MajorName == "MIS");

                MajorPosition mp68 = new MajorPosition();
                mp68.Position = p27;
                mp68.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp68);




                Position p28 = new Position() { PositionTitle = "Big Data Analyst", PositionType = "FT", Location = "Dallas, Texas", Deadline = new DateTime(2019, 5, 9) };
                p28.Company = db.Companies.FirstOrDefault(p => p.CompanyName == "United Airlines");
                //p28.Major = db.Majors.FirstorDefault(p => p.MajorName == "MIS, Finance");

                MajorPosition mp69 = new MajorPosition();
                mp69.Position = p28;
                mp69.Major = db.Majors.FirstOrDefault(p => p.MajorName == "MIS");
                MajorPositions.Add(mp69);

                MajorPosition mp70 = new MajorPosition();
                mp70.Position = p28;
                mp70.Major = db.Majors.FirstOrDefault(p => p.MajorName == "Finance");
                MajorPositions.Add(mp70);

                try
                {
                    foreach (Position positionToAdd in Positions)
                    {
                        strPositionTitle = positionToAdd.PositionTitle;
                        Position dbPosition = db.Positions.FirstOrDefault(a => a.PositionTitle == positionToAdd.PositionTitle);
                        if (dbPosition == null) //this title doesn't exist
                        {
                            db.Positions.Add(positionToAdd);
                            db.SaveChanges();
                            intPositionsAdded += 1;
                        }
                        else //book exists - update values
                        {
                            dbPosition.PositionTitle = positionToAdd.PositionTitle;
                            dbPosition.PositionType = positionToAdd.PositionType;
                            dbPosition.Location = positionToAdd.Location;
                            dbPosition.Deadline = positionToAdd.Deadline;
                            dbPosition.Description = positionToAdd.Description;
                            db.Update(positionToAdd);
                            db.SaveChanges();
                            intPositionsAdded += 1;
                        }
                    }
                
                }
                catch (Exception ex)
                {
                    String msg = "  Repositories added:" + intPositionsAdded + "; Error on " + strPositionTitle;
                    throw new InvalidOperationException(ex.Message + msg);
                }

                try
                {
                    foreach (MajorPosition majorPositionToAdd in MajorPositions)
                    {
                        idMajorPosition = majorPositionToAdd.MajorPositionID;
                        MajorPosition dbMajorPosition = db.MajorPositions.FirstOrDefault(a => a.MajorPositionID == majorPositionToAdd.MajorPositionID);
                        if (dbMajorPosition == null) //this title doesn't exist
                        {
                            db.MajorPositions.Add(majorPositionToAdd);
                            db.SaveChanges();
                            intMajorPositionsAdded += 1;
                        }
                        else //book exists - update values
                        {
                            dbMajorPosition.Major = majorPositionToAdd.Major;
                            dbMajorPosition.Position = majorPositionToAdd.Position;
                            db.Update(dbMajorPosition);
                            db.SaveChanges();
                            intMajorPositionsAdded += 1;
                        }
                    }

                }
                catch (Exception ex)
                {
                    String msg = "  Repositories added:" + intMajorPositionsAdded + "; Error on " + idMajorPosition.ToString();
                    throw new InvalidOperationException(ex.Message + msg);
                }

            }
            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}

