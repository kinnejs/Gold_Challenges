using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims_Repo
{
    public class ClaimsRepository
    {
        private List<Claims> _listOfClaims = new List<Claims>();

        //Create
        public void AddClaimToList(Claims claim)
        {
            _listOfClaims.Add(claim);
        }

        //Read
        public List<Claims> GetClaimsList()
        {
            return _listOfClaims;
        }

        //Update 
        public bool UpdateExistingList(int originalClaimID, Claims newClaimId)
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
        public bool RemoveClaimFromList(int claimID)
        {
            Claims claim = GetClaimsByClaimID(claimID);

            if(claim == null)
            {
                return false;
            }

            int begCount = _listOfClaims.Count;
            _listOfClaims.Remove(claim);

            if (begCount > _listOfClaims.Count)
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
            foreach(Claims claim in _listOfClaims)
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
