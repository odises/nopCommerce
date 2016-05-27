using System.Collections.Generic;
using Nop.Core;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Messages;
using Nop.Core.Domain.Orders;
using Nop.Core.Domain.Shipping;
using Nop.Services.Events;
using Nop.Services.Localization;
using Nop.Services.Stores;

namespace Nop.Services.Messages
{
    public class RobustWorkflowMessageService : WorkflowMessageService
    {
        public RobustWorkflowMessageService(IMessageTemplateService messageTemplateService, IQueuedEmailService queuedEmailService, ILanguageService languageService, ITokenizer tokenizer, IEmailAccountService emailAccountService, IMessageTokenProvider messageTokenProvider, IStoreService storeService, IStoreContext storeContext, EmailAccountSettings emailAccountSettings, IEventPublisher eventPublisher) : base(messageTemplateService, queuedEmailService, languageService, tokenizer, emailAccountService, messageTokenProvider, storeService, storeContext, emailAccountSettings, eventPublisher)
        {
        }

        public override int SendCustomerWelcomeMessage(Customer customer, int languageId)
        {
            return base.SendCustomerWelcomeMessage(customer, languageId);
        }

        public override int SendCustomerEmailValidationMessage(Customer customer, int languageId)
        {
            return base.SendCustomerEmailValidationMessage(customer, languageId);
        }

        public override int SendCustomerPasswordRecoveryMessage(Customer customer, int languageId)
        {
            return base.SendCustomerPasswordRecoveryMessage(customer, languageId);
        }

        public override int SendOrderPaidCustomerNotification(Order order, int languageId, string attachmentFilePath = null,
            string attachmentFileName = null)
        {
            return base.SendOrderPaidCustomerNotification(order, languageId, attachmentFilePath, attachmentFileName);
        }

        public override int SendOrderPlacedCustomerNotification(Order order, int languageId, string attachmentFilePath = null,
            string attachmentFileName = null)
        {
            return base.SendOrderPlacedCustomerNotification(order, languageId, attachmentFilePath, attachmentFileName);
        }

        public override int SendShipmentSentCustomerNotification(Shipment shipment, int languageId)
        {
            return base.SendShipmentSentCustomerNotification(shipment, languageId);
        }

        public override int SendShipmentDeliveredCustomerNotification(Shipment shipment, int languageId)
        {
            return base.SendShipmentDeliveredCustomerNotification(shipment, languageId);
        }

        public override int SendOrderCompletedCustomerNotification(Order order, int languageId, string attachmentFilePath = null,
            string attachmentFileName = null)
        {
            return base.SendOrderCompletedCustomerNotification(order, languageId, attachmentFilePath, attachmentFileName);
        }

        public override int SendOrderCancelledCustomerNotification(Order order, int languageId)
        {
            return base.SendOrderCancelledCustomerNotification(order, languageId);
        }

        public override int SendOrderRefundedCustomerNotification(Order order, decimal refundedAmount, int languageId)
        {
            return base.SendOrderRefundedCustomerNotification(order, refundedAmount, languageId);
        }

        public override int SendNewOrderNoteAddedCustomerNotification(OrderNote orderNote, int languageId)
        {
            return base.SendNewOrderNoteAddedCustomerNotification(orderNote, languageId);
        }

        public override int SendProductEmailAFriendMessage(Customer customer, int languageId, Product product, string customerEmail,
            string friendsEmail, string personalMessage)
        {
            return base.SendProductEmailAFriendMessage(customer, languageId, product, customerEmail, friendsEmail, personalMessage);
        }

        public override int SendWishlistEmailAFriendMessage(Customer customer, int languageId, string customerEmail, string friendsEmail,
            string personalMessage)
        {
            return base.SendWishlistEmailAFriendMessage(customer, languageId, customerEmail, friendsEmail, personalMessage);
        }

        public override int SendReturnRequestStatusChangedCustomerNotification(ReturnRequest returnRequest, OrderItem orderItem, int languageId)
        {
            return base.SendReturnRequestStatusChangedCustomerNotification(returnRequest, orderItem, languageId);
        }

        public override int SendGiftCardNotification(GiftCard giftCard, int languageId)
        {
            return base.SendGiftCardNotification(giftCard, languageId);
        }

        public override int SendBackInStockNotification(BackInStockSubscription subscription, int languageId)
        {
            return base.SendBackInStockNotification(subscription, languageId);
        }

        public override int SendTestEmail(int messageTemplateId, string sendToEmail, List<Token> tokens, int languageId)
        {
            return base.SendTestEmail(messageTemplateId, sendToEmail, tokens, languageId);
        }

    }
}
