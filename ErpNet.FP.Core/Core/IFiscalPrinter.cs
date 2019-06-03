﻿namespace ErpNet.FP.Core
{
    /// <summary>
    /// Represents the capabilities of a connected fiscal printer.
    /// </summary>
    public interface IFiscalPrinter
    {
        /// <summary>
        /// Gets information about the connected device.
        /// </summary>
        /// <returns>Device information.</returns>
        DeviceInfo DeviceInfo { get; }

        /// <summary>
        /// Checks whether the device is currently ready to accept commands.
        /// </summary>
        DeviceStatusWithDateTime CheckStatus();

        /// <summary>
        /// Sets the device date and time
        /// </summary>
        DeviceStatus SetDateTime(CurrentDateTime currentDateTime);

        /// <summary>
        /// Prints the specified receipt.
        /// </summary>
        /// <param name="receipt">The receipt to print.</param>
        (ReceiptInfo, DeviceStatus) PrintReceipt(Receipt receipt);

        /// <summary>
        /// Prints the specified reversal receipt.
        /// </summary>
        /// <param name="reversalReceipt">The reversal receipt.</param>
        /// <returns></returns>
        DeviceStatus PrintReversalReceipt(ReversalReceipt reversalReceipt);

        /// <summary>
        /// Prints a deposit money note.
        /// </summary>
        /// <param name="amount">The deposited amount. Should be greater than 0.</param>
        DeviceStatus PrintMoneyDeposit(TransferAmount transferAmount);

        /// <summary>
        /// Prints a withdraw money note.
        /// </summary>
        /// <param name="amount">The withdrawn amount. Should be greater than 0.</param>
        DeviceStatus PrintMoneyWithdraw(TransferAmount transferAmount);

        /// <summary>
        /// Prints a zreport.
        /// </summary>
        DeviceStatus PrintZReport(Credentials credentials);

        /// <summary>
        /// Prints a xreport.
        /// </summary>
        DeviceStatus PrintXReport(Credentials credentials);
    }
}