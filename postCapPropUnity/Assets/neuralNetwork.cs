

public class neuralNetwork{

	private int[] layers;
	private float[][] neurons;
	private float [][][] weights;

	public NeuralNetwork(int[] layers)
	{
		this.layers = new int[layers.Length];
		for (int i = 0;i<layers.Length;i++)
		{
			this.layers[i] = layers[i];
		}

		InitNeurons();
		InitWeights();
	}

	private void InitNeurons()
	{

	}
	private void InitWeights(){

	}

}
