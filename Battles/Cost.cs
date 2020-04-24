using System;
namespace Norman
{
    public interface Cost
    {
        int cost { get; set; }
        void UseCost(Character user);
    }
}
