﻿using DevelopmentInProgress.MarketView.Interface.Model;
using System;

namespace DevelopmentInProgress.Wpf.Common.Model
{
    public class Candlestick : EntityBase
    {
        private decimal open;
        private decimal close;
        private decimal high;
        private decimal low;
        private DateTime openTime;
        private DateTime closeTime;

        public string Symbol { get; set; }
        public CandlestickInterval Interval { get; set; }
        public decimal Volume { get; set; }
        public decimal QuoteAssetVolume { get; set; }
        public long NumberOfTrades { get; set; }
        public decimal TakerBuyBaseAssetVolume { get; set; }
        public decimal TakerBuyQuoteAssetVolume { get; set; }

        public DateTime OpenTime
        {
            get { return openTime; }
            set
            {
                if(openTime != value)
                {
                    openTime = value;
                    OnPropertyChanged("OpenTime");
                }
            }
        }

        public decimal Open
        {
            get { return open; }
            set
            {
                if (open != value)
                {
                    open = value;
                    OnPropertyChanged("Open");
                }
            }
        }

        public decimal High
        {
            get { return high; }
            set
            {
                if (high != value)
                {
                    high = value;
                    OnPropertyChanged("High");
                }
            }
        }

        public decimal Low
        {
            get { return low; }
            set
            {
                if (low != value)
                {
                    low = value;
                    OnPropertyChanged("Low");
                }
            }
        }

        public decimal Close
        {
            get { return close; }
            set
            {
                if (close != value)
                {
                    close = value;
                    OnPropertyChanged("Close");
                }
            }
        }

        public DateTime CloseTime
        {
            get { return closeTime; }
            set
            {
                if (closeTime != value)
                {
                    closeTime = value;
                    OnPropertyChanged("CloseTime");
                }
            }
        }
    }
}