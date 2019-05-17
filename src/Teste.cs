using MaxiPago.DataContract;
using MaxiPago.DataContract.Transactional;
using MaxiPago.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxiPago
{
    public class Teste
    {
        static void Main(string[] args)
        {
            Transaction transaction = new Transaction();
            transaction.Environment = "TEST";

            ResponseBase response = transaction.Auth(
              "XXX", // 'merchantId' - REQUIRED: Merchant ID assigned by maxiPago!  //
              "XXX", // 'merchantKey' - REQUIRED: Merchant Key assigned by maxiPago! //
              "ORD937393483", // 'referenceNum' - REQUIRED: Merchant internal order number //
              133.45, // 'chargeTotal' - REQUIRED: Transaction amount in US format //
              "4111111111111111", // 'creditCardNumber' - REQUIRED: Full credit card number //
              "03", // 'expMonth' - REQUIRED: Credit card expiration month with 2 digits //
              "2020", // 'expYear' - REQUIRED: Credit card expiration year with 4 digits //
              null, // 'cvvInd' - Optional: Indicator of absense of CVV code  //
              "123", // 'cvvNumber' - RECOMMENDED: Credit card verification number //
              null, // 'authentication' - Optional: Valid only for Cielo. Please see full documentation for more info //
              "1", // 'processorId' - REQUIRED: Acquirer code for transaction routing Use '1' for testing. //
              null, // 'numberOfInstallments' - Optional: Number of installments for credit card purchases ("parcelas") //
                    // Send 'null' if no installments are used //
              "N", // 'chargeInterest' - Optional: Charge interest flag (Y/N) for installment purchase ("com" e "sem" juros) //
              "127.0.0.1", // 'ipAddress' - Optional //
              null, // 'customerIdExt' - Optional: Merchant internal customer number //
              "BRL", // 'currencyCode' - Optional: Currency code. Valid only for ChasePaymentech. Please see full documentation for more info //
              "N",
              "DOTNET", // 'softDescriptor' - Optional
              0.00 // 'iataFee' - Optional
            );

            if (response.IsTransactionResponse)
            {
                TransactionResponse result = response as TransactionResponse;

                if (result.ResponseCode == "0")
                {
                    // Success
                }
                else
                {
                    // Decline
                }
            }
            else if (response.IsErrorResponse)
            {
                ErrorResponse result = response as ErrorResponse;
                // Fail
            }
        }
    }
}
