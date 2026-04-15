namespace DesignPatterns.Mediator;

public class TrainStation : IMediator
{
    private readonly Dictionary<string, ITrain> trains = [];
    private readonly LinkedList<string> trainQueue = [];
    private string? trainOnPlatform;

    public bool NotifyAboutArrival(string trainName)
    {
        if (!string.IsNullOrEmpty(trainOnPlatform))
        {
            trainQueue.AddLast(trainName);
            return false;
        } else
        {
            trainOnPlatform = trainName;
            return true;
        }
    }

    public void NotifyAboutDeparture(string trainName)
    {
        if (trainName == trainOnPlatform)
        {
            trainOnPlatform = null;

            string nextTrainName = trainQueue.First();
            if (!string.IsNullOrEmpty(nextTrainName)
                && trains.TryGetValue(nextTrainName, out ITrain? nextTrain))
            {
                Console.WriteLine(nextTrain.Name);
                trains.Remove(nextTrainName);
                nextTrain.Arrive(this);
                trains.Add(nextTrainName, nextTrain);
                trainOnPlatform = nextTrainName;
            }    
        }
    }

    public void Accept(ITrain train)
    {
        if (trains.ContainsKey(train.Name))
        {
            Console.WriteLine($"${train.Name} has already arrived");
            return;
        }

        train.Arrive(this);
        trains.Add(train.Name, train);
    }

    public void Depart(string trainName)
    {
        if (trains.TryGetValue(trainName, out ITrain? train)) {
            trains.Remove(train.Name);
            train.Depart(this);
        } else
        {
            Console.WriteLine($"{trainName} is not on the station");
        }
    }
}
