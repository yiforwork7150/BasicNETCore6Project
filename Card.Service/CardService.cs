using CardProject.Core;

namespace CardProject.Service
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardDataReposity;

        /// <summary>
        /// 建構式
        /// </summary>
        public CardService(ICardRepository cardRepository) 
        {
            _cardDataReposity = cardRepository;
        }

        /// <summary>
        /// 取得第N張卡片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Card? Get(int id)
        {
            return _cardDataReposity.Get(id);
        }

        /// <summary>
        /// 取得所有卡片
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Card> GetAll()
        {
            return _cardDataReposity.GetAll();
        }

        /// <summary>
        /// 取得卡片 (含條件)
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public IEnumerable<Card> GetList(Card card)
        {
            var result = _cardDataReposity.GetList(card, 0, 0);

            return result;
        }

        /// <summary>
        /// 取得N張卡片
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public IEnumerable<Card> GetSomeCards(int count)
        {
            var result = _cardDataReposity.GetSome(count);

            return result;
        }

        /// <summary>
        /// 新增卡片
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool Insert(Card card)
        {
            var result = _cardDataReposity.Insert(card);

            return result;
        }

        /// <summary>
        /// 新增多張卡片
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public Task<bool> InsertManyAsync(IEnumerable<Card> cards)
        {
            var result = _cardDataReposity.InsertManyAsync(cards);

            return result;
        }
        /// <summary>
        /// 更新卡片
        /// </summary>
        /// <param name="id"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool Update(int id, Card card)
        {
            var result = _cardDataReposity.Update(id, card);

            return result;
        }

        /// <summary>
        /// 刪除卡片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return _cardDataReposity.Delete(id);
        }
    }
}