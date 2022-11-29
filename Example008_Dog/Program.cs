int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondfriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;

while (distance > 10)
{
    if (friend == 1)
    {
      time = distance / (firstFriendSpeed + dogSpeed);
      friend = 2;

    } else
    {
       time = distance / (secondfriendSpeed + dogSpeed);
       friend = 1;
        
        
    distance = distance - (firstFriendSpeed + secondfriendSpeed) * time;
    }

    count = count + 1;

    Console.WriteLine(count);
}