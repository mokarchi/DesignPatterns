using System;

namespace ChainOfResponsibility
{
    public class TwoHundredHandler : Handler
    {
        public override void dispatchRs(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 200;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred notes are dispatched by TwoHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred note is dispatched by TwoHundredHandler");
                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 200;
            if (pendingAmountToBeProcessed > 0)
            {
                rsHandler.dispatchRs(pendingAmountToBeProcessed);
            }
        }
    }
}
