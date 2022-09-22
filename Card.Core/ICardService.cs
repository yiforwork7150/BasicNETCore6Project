namespace CardProject.Core
{
    public interface ICardService
    {
        /// <summary>
        /// 取得N張卡片
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public IEnumerable<Card> GetSomeCards(int count);
        /// <summary>
        ///  取得所有卡片
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Card> GetAll();
        /// <summary>
        /// 取得卡片(含條件)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Card> GetList(Card card);
        //public Task<bool> InsertManyAsync(IEnumerable<Card> dtos);

        /// <summary>
        /// 查詢卡片
        /// </summary>
        /// <param name="id">卡片編號</param>
        /// <returns></returns>   
        public Card Get(int id);

        /// <summary>
        /// 新增卡片
        /// </summary>
        /// <param name="parameter">卡片參數</param>
        /// <returns></returns>
        public bool Insert(Card card);

        /// <summary>
        /// 新增多張卡片
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public Task<bool> InsertManyAsync(IEnumerable<Card> cards);
        /// <summary>
        /// 更新卡片
        /// </summary>
        /// <param name="id">卡片編號</param>
        /// <param name="parameter">卡片參數</param>
        /// <returns></returns>
        public bool Update(int id, Card card);

        /// <summary>
        /// 刪除卡片
        /// </summary>
        /// <param name="id">卡片編號</param>
        /// <returns></returns>
        public bool Delete(int id);
    }
}
