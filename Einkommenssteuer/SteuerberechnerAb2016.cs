namespace Einkommenssteuer;

public class SteuerberechnerAb2016 : ISteuerberecher {
    const float GRUNDFREIBETRAG = 9168f;
    const float STUFE_2 = 14254f;
    const float SUTFE_3 = 55960f;
    const float STUFE_4 = 265326f;


    public float CalculateSteuer(float einkommen) {
        float x = GetX(einkommen);
        float y = GetY(einkommen);
        float z = GetZ(einkommen);

        // switch expression with pattern matching
        return MathF.Round(einkommen switch {
            <= GRUNDFREIBETRAG => 0f,
            <= STUFE_2 => (980.14f * y + 1400) * y,
            <= SUTFE_3 => (216.15f * z + 2397) * z + 965.58f,
            <= STUFE_4 => 0.42f * x - 8780.9f,
            _ => 0.45f * x - 16740.68f
        }, 2);
    }

    float GetY(float einkommen) => (einkommen - GRUNDFREIBETRAG) / 10000f;

    float GetX(float einkommen) => einkommen;

    float GetZ(float einkommen) => (einkommen - STUFE_2) / 10000f;
}