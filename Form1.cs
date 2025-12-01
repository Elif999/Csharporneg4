namespace WinFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int arttir = Convert.ToInt32(textBox1.Text);
            arttir+=1;
            textBox1.Text = arttir.ToString();

            if (arttir >= 1)
            {
                button2.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int azalt = Convert.ToInt32(textBox1.Text);
            azalt -= 1;
            textBox1.Text = azalt.ToString();
            if (azalt == 0)
            {
                button2.Enabled = false;
            }
            
        }
    }
}
/*
 Tabii ki! Verdiðiniz kod parçasý, bir Windows Forms uygulamasýnda bir sayýyý artýrýp 
azaltan basit bir uygulama oluþturuyor.
Kullanýcý, bir butona týklayarak sayýyý artýrabilir ve 
Baþka bir butona týklayarak sayýyý azaltabilir. 
Þimdi kodun mantýðýný adým adým açýklayayým.

Kodun Tamamý:
private void button1_Click(object sender, EventArgs e)
{
    int arttir = Convert.ToInt32(textBox1.Text);
    arttir += 1;
    textBox1.Text = arttir.ToString();

    if (arttir >= 1)
    {
        button2.Enabled = true;
    }
}

private void Form1_Load(object sender, EventArgs e)
{
    textBox1.Text = "1";
}

private void button2_Click(object sender, EventArgs e)
{
    int azalt = Convert.ToInt32(textBox1.Text);
    azalt -= 1;
    textBox1.Text = azalt.ToString();
    
    if (azalt == 0)
    {
        button2.Enabled = false;
    }
}
Adým Adým Açýklama

Form Yüklenirken Baþlangýç Deðeri Ayarlama:
private void Form1_Load(object sender, EventArgs e)
{
    textBox1.Text = "1";
}
Uygulama açýldýðýnda (Form1_Load olayý), 
textBox1 metin kutusunun baþlangýç deðeri 1 olarak ayarlanýr. 
Bu, kullanýcýya baþlangýçta bir sayý gösterir.

Artýrma Butonuna Týklama Olayý:
private void button1_Click(object sender, EventArgs e)
{
    int arttir = Convert.ToInt32(textBox1.Text);
    arttir += 1;
    textBox1.Text = arttir.ToString();

    if (arttir >= 1)
    {
        button2.Enabled = true;
    }
}
Kullanýcý button1 butonuna týkladýðýnda bu metot çalýþýr.
textBox1'den alýnan deðer arttir deðiþkenine atanýr ve bu deðer 1 artýrýlýr.
Yeni deðer, textBox1'e geri yazýlýr.
Eðer arttir deðeri 1 veya daha büyükse, button2 butonu etkinleþtirilir (Enabled = true).
Bu koþul, button2'nin her zaman etkin olmasýný saðlar, 
çünkü baþlangýçta textBox1'deki deðer 1'dir ve 
Artýrma iþlemi sonrasýnda bu koþul her zaman saðlanýr.

Azaltma Butonuna Týklama Olayý:
private void button2_Click(object sender, EventArgs e)
{
    int azalt = Convert.ToInt32(textBox1.Text);
    azalt -= 1;
    textBox1.Text = azalt.ToString();
    
    if (azalt == 0)
    {
        button2.Enabled = false;
    }
}
Kullanýcý button2 butonuna týkladýðýnda bu metot çalýþýr.
textBox1'den alýnan deðer azalt deðiþkenine atanýr ve bu deðer 1 azaltýlýr.
Yeni deðer, textBox1'e geri yazýlýr.
Eðer azalt deðeri 0 olursa, button2 butonu devre dýþý býrakýlýr (Enabled = false). 
Bu, kullanýcý sayýyý sýfýra düþürdüðünde azaltma butonunun kullanýlmasýný engeller.

Özet
Uygulama açýldýðýnda textBox1'de 1 deðeri gösterilir.
Kullanýcý button1 butonuna týkladýðýnda, sayý 1 artýrýlýr.
Kullanýcý button2 butonuna týkladýðýnda, sayý 1 azaltýlýr.
Sayý 0 olduðunda, button2 butonu devre dýþý býrakýlýr.
Kullaným Senaryosu
Uygulama açýldýðýnda textBox1'de 1 görünür.
Kullanýcý button1'e týklarsa, textBox1'deki deðer 2 olur.
Kullanýcý button2'ye týklarsa, textBox1'deki deðer 1 olur.
Kullanýcý tekrar button2'ye týklarsa,
textBox1'deki deðer 0 olur ve `button2 devre dýþý kalýr.
*/