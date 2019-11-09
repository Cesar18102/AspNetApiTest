using System.Threading.Tasks;
using System.Collections.Generic;

using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Repo.Impl;
using AspNetBlankAppTest.Repo.Util;
using System;

namespace AspNetBlankAppTest.Service
{
    public class PayService
    {
        private PayRepo payRepo { get; set; }
        public PayService(IRepoFactory repoFactory) => payRepo = new PayRepo(repoFactory);

        public async Task Pay(PaymentInfo paymentInfo) => await payRepo.Add(paymentInfo);
        public async Task<IEnumerable<PaymentInfo>> GetAll() => await payRepo.Get();
        public async Task<IEnumerable<PaymentInfo>> Get(int userId) => await payRepo.Get(userId);
    }
}