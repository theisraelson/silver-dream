using System;
namespace SilverDream
{
    public interface Cost
    {
        int cost { get; set; }
        void UseCost(Character user);
    }
}
