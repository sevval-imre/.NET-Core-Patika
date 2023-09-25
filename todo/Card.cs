public class Card{
    public string Title{get; set;}
    public string Content {get; set;}
    public Type Type{get; set;}
    public CardSize cardSize{get; set;}
    public Uyeler uyeler{get; set;}

    public Card(string title, string content, Type type, CardSize size, Uyeler uyeler){
        this.Title=title;
        this.Content=content;
        this.Type=type;
        this.cardSize=size;
        this.uyeler=uyeler;
    }
}