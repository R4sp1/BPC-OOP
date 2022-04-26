# BOOP – 12. Cvičení

 1. Vytvořte nový projekt založený na šabloně „ASP.NET Web Application (.NET Framework)“, profil „Web API“. Půjde o webovou službu sloužící jako kalkulačka s operacemi plus, minus, krát a děleno. Data mezi klientem a webovou službou si budeme předávat ve formátu který bude definován následující pomocnou třídou (v projektu si ji přidáme ideálně do složky Models):

```C#
public class CalcData
{
public string Operace { get; set; }
public decimal Operand1 { get; set; }
public decimal Operand2 { get; set; }
}
```


Nahraďte ve vygenerované třídě ValuesController ve složce Controllers výchozí metodu public void Post([FromBody] string value) novou metodou, která bude konzumovat data ve formátu třídy CalcData a výsledek bude  typu decimal:  public decimal Post([FromBody] CalcData calcData) Tuto metodu implementujte, využijte k tomu příkaz switch pro hodnotu calcData.Operace

2. Vytvořte webovou aplikaci představující jednoduchou kalkulačku pracující se dvěma operandy a využívající pro samotný výpočet webovou službu (založeno na šabloně „ASP.NET Web Application (.NET Framework)“, profil „Empty“). Vytvořte pomocnou třídu pro výměnu dat CalcData jako v projektu v bodu 1. Vytvořte 2 webové formuláře (Web Form) Default a  Vysledek. Pro snadnou komunikaci s webovou službou přidáme do projektu nuget balíček (pravé tlačítko myší na projektu v Solution exploreru a pak volbou Manage NuGet Packages...) „Microsoft.AspNet.WebApi.Client“. Příklad volání API z webové služby je uveden v následující ukázce metody Kalkuluj:

```C#
private string Kalkuluj(string a, string b, string op)
{
CalcData calcData = new CalcData
{
Operace = op,
Operand1 = Convert.ToDecimal(a),
Operand2 = Convert.ToDecimal(b)
};
HttpClient client = new HttpClient();
client.BaseAddress = new Uri("https://localhost:44323/");
HttpResponseMessage response =
client.PostAsJsonAsync("api/values", calcData).Result;
if (response.IsSuccessStatusCode)
{
decimal odpoved = response.Content.ReadAsAsync<decimal>().Result;
return odpoved.ToString();
}
return "Error";
}
```
Port v nastavení BaseAddress zvolte takový jaký uvidíte při spuštěné webové službě z bodu 1  v prohlížeči (může být u každého z Vás jiný). Aby dotaz na webovou službu fungoval, musí být projekt s webovou službou z bodu 1 spuštěn.

3. Vytvořte WPF aplikaci (založeno na šabloně „WPF App (.NET Framework)“) sloužící stejnému účelu, tedy představující jednoduchou kalkulačku pracující se dvěma operandy a využívající pro samotný výpočet webovou službu. Volání služby udělejte obdobným způsobem jako u bodu 2.


