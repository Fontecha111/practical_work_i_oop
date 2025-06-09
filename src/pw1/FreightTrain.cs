using System;

namespace practicalwork
{
    public class FreightTrain : Train
    {
        private int maxWeight;
        private string freightType;

        public FreightTrain(string ID, int arrivalTime, string type, int maxWeight, string freightType) : base(ID, arrivalTime, type)
        {
            this.maxWeight = maxWeight;
            this.freightType = freightType;
        }

        public int getMaxWeight()
        {
            return this.maxWeight;
        }

        public string getFreightType()
        {
            return this.freightType;
        }

        public override string ShowInfo()
        {
            return $"Freight Train ID: {ID}, Status: {status}, Arrival Time: {arrivalTime}, Max Weight: {maxWeight}, Freight Type: {freightType}";
        }
    }

}