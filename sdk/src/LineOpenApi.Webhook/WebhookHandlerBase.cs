// This file is auto-generated. Do not edit manually.
using System;
using System.Threading.Tasks;
using LineOpenApi.Webhook.Model;

namespace LineOpenApi.Webhook
{
    /// <summary>
    /// Base class for handling LINE webhook events.
    /// This class is auto-generated from OpenAPI specification.
    /// </summary>
    public abstract class WebhookHandlerBase
    {

        /// <summary>
        /// Main event dispatcher - auto-generated based on OpenAPI event types
        /// </summary>
        public virtual async Task HandleEventAsync(Event ev)
        {
            switch (ev)
            {
                case MessageEvent messageEvent:
                    await HandleMessageEventAsync(messageEvent);
                    break;
                case UnsendEvent unsendEvent:
                    await HandleUnsendEventAsync(unsendEvent);
                    break;
                case FollowEvent followEvent:
                    await HandleFollowEventAsync(followEvent);
                    break;
                case UnfollowEvent unfollowEvent:
                    await HandleUnfollowEventAsync(unfollowEvent);
                    break;
                case JoinEvent joinEvent:
                    await HandleJoinEventAsync(joinEvent);
                    break;
                case LeaveEvent leaveEvent:
                    await HandleLeaveEventAsync(leaveEvent);
                    break;
                case MemberJoinedEvent memberJoinedEvent:
                    await HandleMemberJoinedEventAsync(memberJoinedEvent);
                    break;
                case MemberLeftEvent memberLeftEvent:
                    await HandleMemberLeftEventAsync(memberLeftEvent);
                    break;
                case PostbackEvent postbackEvent:
                    await HandlePostbackEventAsync(postbackEvent);
                    break;
                case VideoPlayCompleteEvent videoPlayCompleteEvent:
                    await HandleVideoPlayCompleteEventAsync(videoPlayCompleteEvent);
                    break;
                case BeaconEvent beaconEvent:
                    await HandleBeaconEventAsync(beaconEvent);
                    break;
                case AccountLinkEvent accountLinkEvent:
                    await HandleAccountLinkEventAsync(accountLinkEvent);
                    break;
                case ThingsEvent thingsEvent:
                    await HandleThingsEventAsync(thingsEvent);
                    break;
                case MembershipEvent membershipEvent:
                    await HandleMembershipEventAsync(membershipEvent);
                    break;
                case ModuleEvent moduleEvent:
                    await HandleModuleEventAsync(moduleEvent);
                    break;
                case ActivatedEvent activatedEvent:
                    await HandleActivatedEventAsync(activatedEvent);
                    break;
                case DeactivatedEvent deactivatedEvent:
                    await HandleDeactivatedEventAsync(deactivatedEvent);
                    break;
                case BotSuspendedEvent botSuspendedEvent:
                    await HandleBotSuspendedEventAsync(botSuspendedEvent);
                    break;
                case BotResumedEvent botResumedEvent:
                    await HandleBotResumedEventAsync(botResumedEvent);
                    break;
                case PnpDeliveryCompletionEvent pnpDeliveryCompletionEvent:
                    await HandlePnpDeliveryCompletionEventAsync(pnpDeliveryCompletionEvent);
                    break;
                default:
                    await HandleUnknownEventAsync(ev);
                    break;
            }
        }

        /// <summary>
        /// Message event dispatcher - auto-generated based on message content types
        /// </summary>
        protected virtual async Task HandleMessageEventAsync(MessageEvent ev)
        {
            switch (ev.Message)
            {
                case TextMessageContent textMessageContent:
                    await HandleTextMessageAsync(ev, textMessageContent);
                    break;
                case ImageMessageContent imageMessageContent:
                    await HandleImageMessageAsync(ev, imageMessageContent);
                    break;
                case VideoMessageContent videoMessageContent:
                    await HandleVideoMessageAsync(ev, videoMessageContent);
                    break;
                case AudioMessageContent audioMessageContent:
                    await HandleAudioMessageAsync(ev, audioMessageContent);
                    break;
                case FileMessageContent fileMessageContent:
                    await HandleFileMessageAsync(ev, fileMessageContent);
                    break;
                case LocationMessageContent locationMessageContent:
                    await HandleLocationMessageAsync(ev, locationMessageContent);
                    break;
                case StickerMessageContent stickerMessageContent:
                    await HandleStickerMessageAsync(ev, stickerMessageContent);
                    break;
                default:
                    await HandleUnknownMessageAsync(ev);
                    break;
            }
        }

        protected virtual Task HandleUnsendEventAsync(UnsendEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleFollowEventAsync(FollowEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleUnfollowEventAsync(UnfollowEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleJoinEventAsync(JoinEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleLeaveEventAsync(LeaveEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleMemberJoinedEventAsync(MemberJoinedEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleMemberLeftEventAsync(MemberLeftEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandlePostbackEventAsync(PostbackEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleVideoPlayCompleteEventAsync(VideoPlayCompleteEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleBeaconEventAsync(BeaconEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleAccountLinkEventAsync(AccountLinkEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleThingsEventAsync(ThingsEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleMembershipEventAsync(MembershipEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleModuleEventAsync(ModuleEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleActivatedEventAsync(ActivatedEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleDeactivatedEventAsync(DeactivatedEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleBotSuspendedEventAsync(BotSuspendedEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleBotResumedEventAsync(BotResumedEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandlePnpDeliveryCompletionEventAsync(PnpDeliveryCompletionEvent ev)
            => Task.CompletedTask;

        protected virtual Task HandleTextMessageAsync(MessageEvent ev, TextMessageContent message)
            => Task.CompletedTask;

        protected virtual Task HandleImageMessageAsync(MessageEvent ev, ImageMessageContent message)
            => Task.CompletedTask;

        protected virtual Task HandleVideoMessageAsync(MessageEvent ev, VideoMessageContent message)
            => Task.CompletedTask;

        protected virtual Task HandleAudioMessageAsync(MessageEvent ev, AudioMessageContent message)
            => Task.CompletedTask;

        protected virtual Task HandleFileMessageAsync(MessageEvent ev, FileMessageContent message)
            => Task.CompletedTask;

        protected virtual Task HandleLocationMessageAsync(MessageEvent ev, LocationMessageContent message)
            => Task.CompletedTask;

        protected virtual Task HandleStickerMessageAsync(MessageEvent ev, StickerMessageContent message)
            => Task.CompletedTask;

        protected virtual Task HandleUnknownEventAsync(Event ev)
        {
            return Task.CompletedTask;
        }

        protected virtual Task HandleUnknownMessageAsync(MessageEvent ev)
        {
            return Task.CompletedTask;
        }
    }
}
