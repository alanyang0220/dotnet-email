using Ardalis.Specification;
using Alanyang.DotNetEmail.ApplicationCore.Entities.EmailAggregate;

namespace Alanyang.DotNetEmail.ApplicationCore.Specifications;

public class EmailRecordNotSentSpecification : Specification<EmailRecord>
{
    public EmailRecordNotSentSpecification(int take)
    {
        Query
            .Where(r => r.IsSent == false)
            .Include(r => r.Attachments)
            .Take(take);
    }
}