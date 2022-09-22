using CardProject.Core;

namespace CardProject.Repository
{
    public class CardDataRepository : ICardRepository
    {
        private static List<Card> _fakeDatabase { get; set; } = new List<Card>();
        /// <summary>
        /// 查詢卡片列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Card> GetAll()
        {
            return _fakeDatabase;
        }

        /// <summary>
        /// 取得N張卡片
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public IEnumerable<Card> GetSome(int count)
        {
            return _fakeDatabase.Take(count);
        }

        /// <summary>
        /// 查詢卡片列表 (含條件)
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public IEnumerable<Card> GetList(Card card, int MinAttack, int MaxAttack)
        {
            var result = _fakeDatabase.ToList();

            //if (card.MinAttack.HasValue) { result = result.Where(_ => _.Attack >= card.MinAttack).ToList(); }
            //if (card.MaxAttack.HasValue) { result = result.Where(_ => _.Attack <= card.MaxAttack).ToList(); }
            //if (card.MinHealth.HasValue) { result = result.Where(_ => _.Health >= card.MinHealth).ToList(); }
            //if (card.MaxHealth.HasValue) { result = result.Where(_ => _.Health <= card.MaxHealth).ToList(); }
            //if (card.MinCost.HasValue) { result = result.Where(_ => _.Cost >= card.MinCost).ToList(); }
            //if (card.MaxCost.HasValue) { result = result.Where(_ => _.Cost <= card.MaxCost).ToList(); }

            //if (String.IsNullOrEmpty(card.Name))
            //{
            //    result = result.Where(_ => _.Name.Contains(card.Name)).ToList();
            //}

            return result;
        }

        /// <summary>
        /// 取得第N張卡片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Card? Get(int id)
        {
            return _fakeDatabase.ElementAtOrDefault(id);
        }

        /// <summary>
        /// 新增卡片
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool Insert(Card card)
        {
            _fakeDatabase.Add(card);
            return true;
        }

        /// <summary>
        /// 新增多張卡片
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public async Task<bool> InsertManyAsync(IEnumerable<Card> cards)
        {
            _fakeDatabase.AddRange(cards);
            await Task.Delay(1000);
            return true;
        }

        /// <summary>
        /// 更新卡片
        /// </summary>
        /// <param name="id"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool Update(int id, Card card)
        {
            _fakeDatabase[id] = card;
            return true;
        }

        /// <summary>
        /// 刪除卡片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            _fakeDatabase.RemoveAt(id);
            return true;
        }
    }
}