using System;
using Core.Common;

namespace ACM.BL.Entities
{
    /// <summary>
    /// Manages a Single Customer
    /// </summary>
    public class Customer
    {
        public int CustimerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public OperationResult ValidateEmail()
        {
            var opResult = new OperationResult();

            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                opResult.Success = false;
                opResult.MessageList.Add("Email address is null");
            }

            if (!ValidateTheFormatOfTheEmail())
            {
                opResult.Success = false;
                opResult.MessageList.Add("Email address is not in a correct format");
            }

            if (!ValidateDomainExists())
            {
                opResult.Success = false;
                opResult.MessageList.Add("Email address does not include a valid domain");
            }

            return opResult;
        }

        private static bool ValidateDomainExists()
        {
            return true;
        }

        private static bool ValidateTheFormatOfTheEmail()
        {
            return true;
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            if(string.IsNullOrWhiteSpace(goalSteps))
                throw new ArgumentException("Goal must be entered");
            if(string.IsNullOrWhiteSpace(actualSteps))
                throw new ArgumentException("Actual steps count must be entered", nameof(actualSteps));

            if (!decimal.TryParse(goalSteps, out var goalStepsCount))
                throw new ArgumentException("Goal must be numeric", nameof(goalSteps));

            if (!decimal.TryParse(actualSteps, out var actualStepsCount))
                throw new ArgumentException("Actual steps must be numeric", nameof(actualSteps));

            return CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepsCount, decimal actualStepsCount)
        {
            if (goalStepsCount <= 0)
                throw new ArgumentException("Goal must be greater then 0", nameof(goalStepsCount));
            if(actualStepsCount < 0)
                throw new ArgumentException("Actual steps must be greater then 0", nameof(actualStepsCount));
            return Math.Round((actualStepsCount / goalStepsCount) * 100, 2);
        }
    }
}
