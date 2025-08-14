using System;

class Program
{
    // Leonardo Wilches - W06 Eternal Quest Program
    // To add creativity, I created a method in GoalManager Class where you level up depending on your score. The more goals you complete, the more levels you can reach, just like in a game.
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}