using System;

namespace AElf.Net.SDK.Infrastructure.Dto
{
    public class BlockHeaderDto
    {
        public string PreviousBlockHash { get; set; }

        public string MerkleTreeRootOfTransactions { get; set; }

        public string MerkleTreeRootOfWorldState { get; set; }

        public string MerkleTreeRootOfTransactionState { get; set; }

        public string Extra { get; set; }

        public long Height { get; set; }

        public string Time { get; set; }

        public string ChainId { get; set; }

        public string Bloom { get; set; }

        public string SignerPubkey { get; set; }
    }
}