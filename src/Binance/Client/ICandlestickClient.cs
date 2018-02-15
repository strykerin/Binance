﻿using System;
using Binance.Client.Events;
using Binance.Market;

namespace Binance.Client
{
    public interface ICandlestickClient : IJsonClient
    {
        /// <summary>
        /// The candlestick event.
        /// </summary>
        event EventHandler<CandlestickEventArgs> Candlestick;

        /// <summary>
        /// Subscribe to the specified symbol.
        /// </summary>
        /// <param name="symbol">The symbol to subscribe.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="callback">An event callback.</param>
        void Subscribe(string symbol, CandlestickInterval interval, Action<CandlestickEventArgs> callback);

        /// <summary>
        /// Unsubscribe a callback from a symbol. If no callback is specified,
        /// then unsubscribe from symbol & interval (all callbacks).
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="interval">The interval.</param>
        /// <param name="callback"></param>
        void Unsubscribe(string symbol, CandlestickInterval interval, Action<CandlestickEventArgs> callback);
    }
}
