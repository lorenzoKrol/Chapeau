using System.Collections.Generic;
using ChapeauModel.Models;
using ChapeauDAL.DAOs;
using System;

namespace ChapeauLogic.Services {
    public class PaymentService {
        private PaymentDAO paymentDAO = new PaymentDAO();

        public void InsertPayment(Payment payment) {
            paymentDAO.InsertPayment(payment);
        }
    }
}
