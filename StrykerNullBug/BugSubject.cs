using System.Diagnostics;

namespace StrykerNullBug
{
    public class BugSubject
    {
        public List<HistoricInstruction> BuildHistoricInstructionResponseModels(
            List<InvestmentChangeEvent> historyRecords)
        {
            var models = new List<HistoricInstruction>();
            foreach (var historyRecord in historyRecords)
            {
                // Create model using basic auto mapper profile mapping.
                var effectiveDate = historyRecord.Increment?.EffectiveStartDate ?? historyRecord.Switch.EffectiveDate;
                var date = effectiveDate.Date;

                // Manually set more complex properties.
                this.SetRedirectionPortfolios(effectiveDate);
                this.SetSwitchPortfolios(effectiveDate);
                this.SetRedirectionStrategy(effectiveDate);
                this.SetSwitchStrategy(effectiveDate);
            }

            return models;
        }

        private void SetRedirectionPortfolios(DateTime effectiveDate)
        {
        }

        private void SetSwitchPortfolios(DateTime effectiveDate)
        {
        }

        private void SetRedirectionStrategy(DateTime effectiveDate)
        {
        }

        private void SetSwitchStrategy(DateTime effectiveDate)
        {
        }

    }
}