/*
Задача "друзья и собака".
Скорости друзей: 1 и 2 м/с, скорость собаки 5 м/с, расстояние между друзьями: 10 000 м.
*/

int count = 0, friend = 2;
double distance = 10000, firstFriendSpeed = 1, secondFriendSpeed = 2, dogSpeed = 5, walkTime = 0;
double initDistance = distance;
while(distance > 10)
{
    if(friend == 1)
    {
        walkTime = distance / (firstFriendSpeed + dogSpeed);    // Текущее время прогулки, секунд
        friend = 2;
    }
    else{
        walkTime = distance / (secondFriendSpeed + dogSpeed);   // Текущее время прогулки, секунд
        friend = 1;
    }
    distance = distance - walkTime * (firstFriendSpeed + secondFriendSpeed);
    count++;
}

Console.WriteLine("Количество пробежек собаки, раз: {0}", count);

double totalTime = (initDistance / (firstFriendSpeed + secondFriendSpeed)) / 60;    // Общее время прогулки, часов
Console.WriteLine("Общее время прогулки, часов: {0}", totalTime);
double dogRunDistance = totalTime * 60 * 5 / 1000;  // Общее расстояние, которое пробежала собака, км
Console.WriteLine("Расстояние, покытое собакой, км: {0}", dogRunDistance);

