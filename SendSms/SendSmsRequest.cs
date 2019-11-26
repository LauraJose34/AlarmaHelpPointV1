using System;

namespace TygerSygnal
{
    class SendSmsRequest
    {
        public string Message { get; set; }
        public string ToPhoneNumbers { get; set; }

        internal string InvalidRequestReason()
        {
            if (Message == null)
            {
                return "No message to send.";
            }

            if (ToPhoneNumbers == null)
            {
                return "Missing 'ToPhoneNumbers'. E.g. '+215561981277;+5215614065246;'";
            }

            return null;
        }

        public bool IsValid()
        {
            return InvalidRequestReason() == null;
        }
    }
}