using AElf.Kernel.Infrastructure;
using AElf.Types;

namespace AElf.Boilerplate.TestBase.SmartContractNameProviders;

public class BatchTransferSmartContractAddressNameProvider
{
    public static readonly Hash Name = HashHelper.ComputeFrom("BatchTransfer");

    public static readonly string StringName = Name.ToStorageKey();
    public Hash ContractName => Name;
    public string ContractStringName => StringName;
}