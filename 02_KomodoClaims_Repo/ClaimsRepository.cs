using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims_Repo
{
    public class ClaimsRepository
    {
        private Queue<Claims> _queueOfClaims = new Queue<Claims>();

        //Create
        public void AddClaimToQueue(Claims claim)
        {
            _queueOfClaims.Enqueue(claim);
        }

        //Read
        public Queue<Claims> GetClaimsQueue()
        {
            return _queueOfClaims;
        }

        //Update 
        public bool UpdateExistingQueue(int originalClaimID, Claims newClaimId)
        {
            //Find the content
            Claims oldClaimID = GetClaimsByClaimID(originalClaimID);

            //Update content
            if(oldClaimID != null)
            {
                oldClaimID.ClaimID = newClaimId.ClaimID;
                oldClaimID.TypeOfClaim = newClaimId.TypeOfClaim;
                oldClaimID.Description = newClaimId.Description;
                oldClaimID.ClaimAmount = newClaimId.ClaimAmount;
                oldClaimID.DateOfIncident = newClaimId.DateOfIncident;
                oldClaimID.DateOfClaim = newClaimId.DateOfClaim;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveClaimFromQueue(int claimID)
        {
            Claims claim = GetClaimsByClaimID(claimID);

            if(claim == null)
            {
                return false;
            }

            int begCount = _queueOfClaims.Count;
            _queueOfClaims.Dequeue();

            if (begCount > _queueOfClaims.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }







        //Helper Method
        public Claims GetClaimsByClaimID(int claimID)
        {
            foreach(Claims claim in _queueOfClaims)
            {
                if(claim.ClaimID == claimID)
                {
                    return claim;
                }
            }
            return null;
        }
    }
}
