using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.AI.Luis;
using Microsoft.Bot.Builder.AI.QnA;

namespace Dispatch_testbot
{
    public interface IBotServices
    {
        LuisRecognizer Dispatch { get; }
        QnAMaker SampleQnA { get; }
    }
}
