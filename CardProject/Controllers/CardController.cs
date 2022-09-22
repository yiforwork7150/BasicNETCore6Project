using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using CardProject.Core;

namespace CardWebAPI.Controllers
{
    /// <summary>
    /// 卡片管理
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="cardService"></param>
        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        /// <summary>
        /// 取得所有卡片
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Card> GetAllCards()
        {
            return _cardService.GetAll();
        }

        /// <summary>
        /// 取得N張卡片
        /// </summary>
        /// <param name="count">卡片數量</param>
        /// <returns></returns>
        [HttpGet("GetSome")]
        public IEnumerable<Card> GetSome([FromQuery] int count)
        {
            return _cardService.GetSomeCards(count);
        }

        /// <summary>
        /// 取得第N張卡片
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        [HttpGet("{index}")]
        public Card GetCard(int index) 
        {
            return _cardService.Get(index);
        }

        /// <summary>
        /// 新增卡片
        /// </summary>
        /// <param name="card">卡片資訊</param>
        /// <returns></returns>
        [HttpPost]
        public bool Post([FromBody] Card card)
        {
            return _cardService.Insert(card);
        }

        /// <summary>
        /// 新增多張卡片
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        [HttpPost("multi")]
        public Task<bool> Post(IEnumerable<Card> cards)
        {
            return _cardService.InsertManyAsync(cards);
        }
        /// <summary>
        /// 更新卡片
        /// </summary>
        /// <param name="id"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        [HttpPost("update")]
        public bool Update(int id, Card card)
        {
            var result = _cardService.Update(id, card);

            return result;
        }

        /// <summary>
        /// 刪除卡片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool Delete(int id)
        {
            return _cardService.Delete(id);
        }
    }
    
}
