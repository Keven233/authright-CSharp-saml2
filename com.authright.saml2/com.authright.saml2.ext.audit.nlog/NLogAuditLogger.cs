using com.authright.saml2.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.authright.saml2.ext.audit.nlog
{
    public class NLogAuditLogger : IAuditLogger
    {
        private static NLog.Logger logger = NLog.LogManager.GetLogger("OIOSAML_AUDIT_LOGGER");

        public void LogEntry(Direction dir, Operation op, string msg, string data, string userHostAddress, string idpId, string assertionId, string sessionId)
        {
            logger.Info(String.Format("Session id: {6}, Direction: {0}, Operation: {1}, User IP: {2}, Idp ID: {3}, Assertion ID: {4}, Message: {5}, Data: {7}", dir, op, userHostAddress, idpId, assertionId, msg, sessionId, data != null ? data : ""));
        }
    }
}
