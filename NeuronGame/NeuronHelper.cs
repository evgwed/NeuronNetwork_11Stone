using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuronNetwork
{
    public class NeuronNetwork
    {
        private List<Neuron> _Neurons = new List<Neuron>();
        private List<int> _UsedNeuronsInStep = new List<int>();

        public NeuronNetwork Init()
        {
            int i = 0;
            while(i< 10){ _Neurons.Add(new Neuron(NeuronSettings.countArry)); i++;}
            return this;
        }
        /*
         * true - взять 1
         * false - взять 2
         */
        public bool GetNeuronValue(int index)
        {
            try
            {
                index--;
                if (index > _Neurons.Count)
                    throw new Exception("Выход за пределы массива в методе GetNeuronValue().");
                _UsedNeuronsInStep.Add(index);
            }
            catch (Exception e)
            {
                NeuronHelper.Write(e.Message);
            }
            return _Neurons[index].GetNeuronValue();
        }
        public void CorrectNeurons(bool isRight)
        {
            try{
                foreach (int item in _UsedNeuronsInStep)
                {
                    if (isRight)
                        _Neurons[item].AddValue();
                    else
                        _Neurons[item].DeleteValue();
                }
                NeuronHelper.Write("Было изменено нейронов: " + _UsedNeuronsInStep.Count.ToString());
                _UsedNeuronsInStep.Clear();
            }
            catch (Exception e)
            {
                NeuronHelper.Write(e.Message);
            }
        }
    }
    public static class NeuronSettings {
        public const int countArry = 20; //Количество вариантов решений в нейроне в начале
        public const int countGameForTrainer = 1000;//поличество игр для обучения
    }

    public static class NeuronHelper{
        private static Random _rand = new Random();
        public static int GetRand(int min, int max)
        {
            return _rand.Next(min,max);
        }

        public static void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Neuron{
        private List<bool> _list = new List<bool>();
        private int _index = int.MinValue;
        
        public Neuron(){}
        public Neuron(int listCount){
            for(int i = 0; i < listCount/2; i++)
            {
                _list.Add(true);
                _list.Add(false);
            }
        }
        
        public bool GetNeuronValue()
        {
            try{
                if (_list.Count == 0)
                    throw new Exception("Нейрон не инициализирован.");
                _index = NeuronHelper.GetRand(0, _list.Count-1);
            }
            catch (Exception e)
            {
                NeuronHelper.Write(e.Message);
                Application.Exit();
            }
            return _list[_index];
        }
        public void DeleteValue()
        {
            try {
                if(_index >= 0 && _index < _list.Count)
                {    
                    _list.RemoveAt(_index);
                    _index = int.MinValue;
                    if (_list.Count == 0)
                    {
                        _list.Add(true);
                        _list.Add(false);
                    }
                }
                else
                    throw new Exception("Индекс выходит за пределы массива в методе DeleteValue().");
            }
            catch (Exception e)
            {
                NeuronHelper.Write(e.Message);
                Application.Exit();
            }
        }
        public void AddValue()
        {
            try {
                if(_index >= 0 && _index < _list.Count)
                {    
                    _list.Add(_list[_index]);
                    _index = int.MinValue;
                }
                else
                    throw new Exception("Индекс выходит за пределы массива в методе AddValue().");
            }
            catch (Exception e)
            {
                NeuronHelper.Write(e.Message);
                Application.Exit();
            }
        }
    }

    public class NeuronTrainer {
        private int _countGames = 0;
        private int _countStone = 11;
        public NeuronTrainer()
        { }
        public NeuronTrainer(int countGames)
        {
            this._countGames = countGames;
        }
        public void Start(NeuronNetwork network)
        {
            while (_countGames > 0)
            {
                GetTrainerStone();
                GetWin(false, network);
                if (_countStone > 0)
                {
                    getNeuronStone(network);
                    GetWin(true, network);
                }
            }
        }
        public void GetWin(bool isNeuron, NeuronNetwork network)
        {
            if (_countStone <= 0)
            {
                network.CorrectNeurons(isNeuron);
                NeuronHelper.Write("Победа " + (isNeuron?"НС!":"тренера!"));
                network.Init();
                _countStone = 11;
                _countGames--;
            }
        }
        public void GetTrainerStone() {
            int stone = NeuronHelper.GetRand(1, 3);
            NeuronHelper.Write(stone.ToString() +" ");
            _countStone -= stone;
        }
        public void getNeuronStone(NeuronNetwork network)
        {
            if (network.GetNeuronValue(_countStone))
            {
                _countStone--;
            }
            else
            {
                _countStone -= 2;
            }
        }
    }
}
