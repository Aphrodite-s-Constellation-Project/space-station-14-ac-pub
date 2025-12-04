namespace Content.Shared.Flash.Components;


/// <summary>
/// Corvax-Next-Avali
/// Модифицирует эффект ослепления для сущности.
/// Используется для изменения длительности или интенсивности вспышки.
/// </summary>

[RegisterComponent]
public sealed partial class FlashModifierComponent : Component
{
    [DataField]
    public float Modifier = 1f;
}
