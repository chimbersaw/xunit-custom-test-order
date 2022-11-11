using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
[assembly: TestCollectionOrderer("CustomTestOrder.DisplayNameOrderer", "CustomTestOrder")]
[assembly: TestCaseOrderer("CustomTestOrder.AlphabeticalOrderer", "CustomTestOrder")]