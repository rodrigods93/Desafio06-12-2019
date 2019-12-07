class BananaR 
{
	private double banana; 
	private double guarana; 
	private string rGuarana;
		private void calcular(){
			try {
				banana=Convert.ToDouble(txtbanana.Text);
				guarana=Math.Sqrt(banana);
				rGuarana=Convert.ToString(guarana); 
				txtResultado.Text = rGuarana;
			} 
			catch(FormatException){ 
				MessageBox.Show("Formatação Errada.");
			}
		}
}