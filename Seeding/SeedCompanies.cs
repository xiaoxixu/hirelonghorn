using hirelonghorn.DAL;
using hirelonghorn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hirelonghorn.Seeding
{
    public static class SeedCompanies
    {
        public static void SeedAllCompanies(AppDbContext db)
        {
            // check to see if all the genres have already been added
            if (db.Companies.Count() == 13)
            {
                //exit the program - we don't need to do any of this
                NotSupportedException ex = new NotSupportedException("Company record count is already 13!");
                throw ex;
            }
            Int32 intCompaniesAdded = 0;
            try
            {
                //Create a list of languages
                List<Company> Companies = new List<Company>();

                Company c1 = new Company() { CompanyName = "Accenture", CompanyEmail = "accenture@example.com", Description = "Accenture is a global management consulting, technology services and outsourcing company.", Industry = "Consulting, Technology" };
                Companies.Add(c1);

                Company c2 = new Company() { CompanyName = "Shell", CompanyEmail = "shell@example.com", Description = "Shell Oil Company, including its consolidated companies and its share in equity companies, is one of America's leading oild and natural gas producers, natural gas marketers, gasoline marketers and petrochemical manufacturers.", Industry = "Energy, Chemicals" };
                Companies.Add(c2);

                Company c3 = new Company() { CompanyName = "Deloitte", CompanyEmail = "deloitte@example.com", Description = "Deloitte is one of the leading professional services organizations in the United States specializing in audit, tax, consulting, and financial advisory services with clients in more than 20 industries.", Industry = "Accounting, Consulting, Technology" };
                Companies.Add(c3);

                Company c4 = new Company() { CompanyName = "Capital One", CompanyEmail = "capitalone@example.com", Description = "Capital One offers a broad spectrum of financial products and services to consumers, small businesses and commercial clients.", Industry = "Financial Services" };
                Companies.Add(c4);

                Company c5 = new Company() { CompanyName = "Texas Instruments", CompanyEmail = "texasinstruments@example.com", Description = "TI is one of the world’s largest global leaders in analog and digital semiconductor design and manufacturing", Industry = "Manufacturing" };
                Companies.Add(c5);

                Company c6 = new Company() { CompanyName = "Hilton Worldwide", CompanyEmail = "hiltonworldwide@example.com", Description = "Hilton Worldwide offers business and leisure travelers the finest in accommodations, service, amenities and value.", Industry = "Hospitality" };
                Companies.Add(c6);

                Company c7 = new Company() { CompanyName = "Aon", CompanyEmail = "aon@example.com", Description = "Aon is the leading global provider of risk management, insurance and reinsurance brokerage, and human resources solutions and outsourcing services.", Industry = "Insurance, Consulting" };
                Companies.Add(c7);

                Company c8 = new Company() { CompanyName = "Adlucent", CompanyEmail = "adlucent@example.com", Description = "Adlucent is a technology and analytics company specializing in selling products through the Internet for online retail clients.", Industry = "Marketing, Technology" };
                Companies.Add(c8);

                Company c9 = new Company() { CompanyName = "Stream Realty Partners", CompanyEmail = "streamrealtypartners@example.com", Description = "Stream Realty Partners, L.P. (Stream) is a national, commercial real estate firm with locations across the country.", Industry = "Real-Estate" };
                Companies.Add(c9);

                Company c10 = new Company() { CompanyName = "Microsoft", CompanyEmail = "microsoft@example.com", Description = "Microsoft is the worldwide leader in software, services and solutions that help people and businesses realize their full potential.", Industry = "Technology" };
                Companies.Add(c10);

                Company c11 = new Company() { CompanyName = "Academy Sports & Outdoors", CompanyEmail = "academysports@example.com", Description = "Academy Sports is intensely focused on being a leader in the sporting goods, outdoor and lifestyle retail arena", Industry = "Retail" };
                Companies.Add(c11);

                Company c12 = new Company() { CompanyName = "United Airlines", CompanyEmail = "unitedairlines@example.com", Description = "United Airlines has the most modern and fuel-efficient fleet (when adjusted for cabin size), and the best new aircraft order book, among U.S. network carriers", Industry = "Transportation" };
                Companies.Add(c12);

                Company c13 = new Company() { CompanyName = "Target", CompanyEmail = "target@example.com", Description = "Target is a leading retailer", Industry = "Retail" };
                Companies.Add(c13);

                foreach (Company companyToAdd in Companies)
                {
                    Company dbCompany = db.Companies.FirstOrDefault(c => c.CompanyName == companyToAdd.CompanyName);
                    if (dbCompany == null)
                    {
                        db.Companies.Add(companyToAdd);
                        db.SaveChanges();
                        intCompaniesAdded += 1;
                    }
                }
            }
            catch
            {
                String msg = "Companies Added: " + intCompaniesAdded.ToString();
                throw new InvalidOperationException(msg);
            }
        }
    }
}
