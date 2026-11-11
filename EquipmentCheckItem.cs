namespace EquipmentAccounting.Checks;

public sealed record EquipmentCheckItem(string InventoryNumber, bool IsOperational, string Notes);