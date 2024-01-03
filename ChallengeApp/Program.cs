using ChallengeApp;

Worker user1 = new Worker("Adam", "Ziobro", "21");
Worker user2 = new Worker("Zuzia", "Lewandowska", "23");
Worker user3 = new Worker("Gabrysia", "Wysocka", "19");


user1.AddScore(8);
user1.AddScore(1);
user1.AddScore(5);

user2.AddScore(6);
user2.AddScore(1);
user2.AddScore(8);

user3.AddScore(8);
user3.AddScore(4);
user3.AddScore(6);



List<Worker> users = new List<Worker>()
{
    user1, user2, user3,
};

int maxResult = -1;
Worker WorkerWithMaxResult = null;

foreach (var user in users)
{
    if(user.Result > maxResult)
    {
        WorkerWithMaxResult = user;
        maxResult = user.Result;
    }
}

Console.WriteLine("Pracownikiem z najlepszym wynikiem zostaje" + " " + WorkerWithMaxResult.Name + " " 
    + WorkerWithMaxResult.Surname + " " + "lat" + " " + WorkerWithMaxResult.Age + ", " 
    + "która zdobyła" + " " + WorkerWithMaxResult.Result + " " + "pkt");