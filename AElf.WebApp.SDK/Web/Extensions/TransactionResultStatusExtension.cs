using System;
using AElf.Types;

namespace AElf.WebApp.SDK.Web.Extensions
{
    public static class TransactionResultStatusExtension
    {
        public static TransactionResultStatus ConvertTransactionResultStatus(this string status)
        {
            return (TransactionResultStatus) Enum.Parse(typeof(TransactionResultStatus), status, true);
        }
    }
}