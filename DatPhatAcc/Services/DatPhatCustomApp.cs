using System.Diagnostics;
using System.Text.Json;

namespace DatPhatAcc.Services
{
    public class DatPhatCustomApp : LarkSuite.CustomAppBase
    {
        public DatPhatCustomApp()
        {
        }

        public override string AppID => "cli_a69a528f75b8d010";

        public override string AppSecret => "KQBjyFL6Yx0qBlLtOUDcvbVjFAbjNrd3";

        public async Task<List<Models.BranchInterestRate>> GetInteresRateList()
        {
            try
            {
                string wikiNode = await GetWikiNodeInformation("X1AawsB77imzzAkvQoJlSeTBgWb");
                string records = await LarkBaseListRecord(wikiNode, "tblOtgeXnUzWEL3j");
                Models.Responses.InterestRateResponse? interestRateResponse = JsonSerializer.Deserialize<Models.Responses.InterestRateResponse>(records);

                if (interestRateResponse is null)
                {
                    throw new Exception("Failed to get interest rate");
                }

                List<Models.BranchInterestRate> branchInterestRates = new List<Models.BranchInterestRate>();
                foreach (var item in interestRateResponse.Data.Items)
                {
                    Models.BranchInterestRate branchInterestRate = new Models.BranchInterestRate();
                    branchInterestRate.BranchId = item.Fields["BranchID"].ToString();
                    branchInterestRate.BranchName = item.Fields["BranchName"].ToString();
                    branchInterestRate.RetailInterestRate = decimal.Parse(item.Fields["RetailInterestRate"].ToString());
                    branchInterestRate.WholeSaleInterestRate = decimal.Parse(item.Fields["WholeSaleInterestRate"].ToString());

                    branchInterestRates.Add(branchInterestRate);
                }

                Debug.WriteLine(wikiNode);
                Debug.WriteLine(records);
                return branchInterestRates;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
