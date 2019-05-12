﻿namespace DevelopmentInProgress.MarketView.Interface.Strategy
{
    public class StrategySubscription
    {
        public string Symbol { get; set; }
        public decimal NotionalMinimumValue { get; set; }
        public int Limit { get; set; }
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public Exchange Exchange { get; set; }
        public Subscribe Subscribe { get; set; }
    }
}