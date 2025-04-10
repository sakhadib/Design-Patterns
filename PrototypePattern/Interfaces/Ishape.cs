namespace PrototypePattern.Interfaces;

public interface Ishape
{
    void Draw();
    void SetColor(string color);
    string GetColor();
    string GetName();
    
    Ishape Clone();
}