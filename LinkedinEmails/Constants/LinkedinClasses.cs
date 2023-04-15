﻿namespace LinkedinEmails.Constants
{
    public class LinkedinClasses
    {
        public static readonly string EmployeesLinkClassName = ".org-top-card-secondary-content__see-all-link";
        public static readonly string EmployeesLinkAllClassName = ".org-top-card-secondary-content__see-all-independent-link a";
        public static readonly string LinkedinNavbarClassName = ".global-nav__me";
        public static readonly string ResultEntityClassName = ".entity-result__item";
        public static readonly string SelectorLoginButton = "button.sign-in-form__submit-btn--full-width";
        public static readonly string PageSelectorClassName = ".artdeco-pagination__indicator";
        public static readonly string IdEmailInput = "#session_key";
        public static readonly string IdPasswordInput = "#session_password";

        public static readonly string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36";
        public static readonly string JsGetEmployeeNames = "Array.from(document.querySelectorAll('.entity-result__title-text a span[dir] span[aria-hidden]')).map(a => a.innerText);";
        public static readonly string JsGetLastPage = "() => {var elem = document.querySelectorAll('.artdeco-pagination__indicator.artdeco-pagination__indicator--number');return elem[elem.length-1].getAttribute('data-test-pagination-page-btn');}";
        public static readonly string JsScrollDown = "() => {window.scrollTo({top: document.body.scrollHeight,left: 0,behavior: 'smooth'});}";
    }
}
